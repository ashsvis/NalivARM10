using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NalivARM10.Model
{
    public abstract class Channel
    {
        protected Channel(string tuning)
        {
        }

        public int WriteTimeout { get; set; } = 5000;
        public int ReadTimeout { get; set; } = 5000;

        public abstract void Open();

        public abstract bool IsOpen { get; protected set; }
        public abstract int BytesToRead { get; }

        public abstract void Close();

        public abstract void Write(byte[] sendBytes, int offset, int length);

        public abstract int ReadByte();

        public static byte[] PrepareFetchRequest(RiserKey key, int address, int regcount)
        {
            var sendBytes = EncodeData((byte)key.NodeAddr, key.Func,
                                       (byte)(address >> 8), (byte)(address & 0xff),
                                       (byte)(regcount >> 8), (byte)(regcount & 0xff), 0, 0);
            var buff = new List<byte>(sendBytes);
            var crc = BitConverter.GetBytes(Crc(buff.ToArray(), buff.Count - 2));
            sendBytes[sendBytes.Length - 2] = crc[0];
            sendBytes[sendBytes.Length - 1] = crc[1];
            return sendBytes;
        }

        public static byte[] PrepareWriteRequest(RiserKey key, int address, int regcount, ushort[] writevals)
        {
            var list = new List<byte>();
            list.AddRange(new[] { (byte)key.NodeAddr, (byte)16 });
            list.AddRange(BitConverter.GetBytes(Swap((ushort)address)));
            list.AddRange(BitConverter.GetBytes(Swap((ushort)regcount)));
            list.Add((byte)(regcount * 2));
            foreach (var writeval in writevals)
                list.AddRange(BitConverter.GetBytes(Swap(writeval)));
            list.AddRange(new byte[] { 0, 0 }); // место для контрольной суммы
            var sendBytes = list.ToArray();
            var crc = BitConverter.GetBytes(Crc(list.ToArray(), list.Count - 2));
            sendBytes[sendBytes.Length - 2] = crc[0];
            sendBytes[sendBytes.Length - 1] = crc[1];
            return sendBytes;
        }

        private static ushort Swap(ushort value)
        {
            var bytes = BitConverter.GetBytes(value);
            var buff = bytes[0];
            bytes[0] = bytes[1];
            bytes[1] = buff;
            return BitConverter.ToUInt16(bytes, 0);
        }

        private static byte[] EncodeData(params byte[] list)
        {
            var result = new byte[list.Length];
            for (var i = 0; i < list.Length; i++) result[i] = list[i];
            return result;
        }

        public static ushort Crc(IList<byte> buff, int len)
        {   // контрольная сумма MODBUS RTU
            ushort result = 0xFFFF;
            if (len <= buff.Count)
            {
                for (var i = 0; i < len; i++)
                {
                    result ^= buff[i];
                    for (var j = 0; j < 8; j++)
                    {
                        var flag = (result & 0x0001) > 0;
                        result >>= 1;
                        if (flag) result ^= 0xA001;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Асинхронный вызов метода запроса данных
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="key"></param>
        /// <param name="address"></param>
        /// <param name="regcount"></param>
        /// <returns></returns>
        public static Task<ushort[]> FetchAsync(Channel channel, RiserKey key, int address, int regcount)
        {
            var task = new Task<ushort[]>(() => Fetch(channel, key, address, regcount));
            task.Start();
            return task;
        }

        /// <summary>
        /// Запрос данных
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="key">Ключ стояка</param>
        /// <param name="address">Начальное смещение</param>
        /// <param name="regcount">Кол-во регистров</param>
        /// <returns></returns>
        public static ushort[] Fetch(Channel channel, RiserKey key, int address, int regcount)
        {
            var sendBytes = PrepareFetchRequest(key, address, regcount);
            var len = (sendBytes[4] * 256 + sendBytes[5]) * 2 + 5;
            var buff = new List<byte>();
            lock (channel)
            {
                channel.Write(sendBytes, 0, sendBytes.Length);
                Thread.Sleep(200);
                var bytesToRead = channel.BytesToRead;
                if (bytesToRead == len || bytesToRead == 5)
                {
                    while (bytesToRead-- > 0)
                        buff.Add((byte)channel.ReadByte());
                }
            }
            if (buff.Count == len)
            {
                // конец приёма блока данных
                var crcCalc = Crc(buff.ToArray(), buff.Count - 2);
                var crcBuff = BitConverter.ToUInt16(buff.ToArray(), buff.Count - 2);
                if (crcCalc == crcBuff)
                {
                    // данные получены правильно
                    regcount = buff[2] / 2;
                    var fetchvals = new ushort[regcount];
                    var n = 3;
                    for (var i = 0; i < regcount; i++)
                    {
                        var raw = new byte[2];
                        raw[0] = buff[n + 1];
                        raw[1] = buff[n];
                        fetchvals[i] = BitConverter.ToUInt16(raw, 0);
                        n += 2;
                    }
                    return fetchvals;
                }
                else
                {
                    // ошибка контрольной суммы
                    return new ushort[] { };
                }
            }
            else
                return new ushort[] { };
        }

    }
}
