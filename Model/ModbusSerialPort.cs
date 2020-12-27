using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Windows.Forms;

namespace NalivARM10
{
    public partial class ModbusSerialPort : SerialPort, IDisposable
    {
        // Other managed resource this class uses.
        private Timer timer = new Timer();

        public ModbusSerialPort()
        {
            InitializeComponent();
            InitializeEvents();
        }

        public ModbusSerialPort(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            InitializeEvents();
        }

        ~ModbusSerialPort()
        {
            timer.Dispose();
        }

        private void InitializeEvents()
        {
            DataReceived += ModbusSerialPort_DataReceived;
            timer.Interval = ReadTimeout < 0 ? 1000 : ReadTimeout;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            // таймаут
            modbusTimeout?.Invoke(this, new EventArgs());
        }

        protected override bool CanRaiseEvents => true;


        public int Node { get; set; }
        public int Func { get; set; }
        public int Address { get; set; }
        public int DataCount { get; set; }
        public int RegCount { get; private set; }
        public ushort[] FetchVals { get; private set; }
        public int ErrorCode { get; private set; }

        public void FetchModbusData()
        {
            RegCount = 0;
            FetchVals = new ushort[RegCount];
            var sendBytes = EncodeData((byte)Node, (byte)Func,
                                       (byte)(Address >> 8), (byte)(Address & 0xff),
                                       (byte)(DataCount >> 8), (byte)(DataCount & 0xff), 0, 0);
            ReceivedBytesThreshold = (sendBytes[4] * 256 + sendBytes[5]) * 2 + 5;
            var buff = new List<byte>(sendBytes);
            var crc = BitConverter.GetBytes(Crc(buff.ToArray(), buff.Count - 2));
            sendBytes[sendBytes.Length - 2] = crc[0];
            sendBytes[sendBytes.Length - 1] = crc[1];
            ErrorCode = 0;
            buff.Clear();
            try
            {
                if (!IsOpen)
                    Open();
                if (IsOpen)
                {
                    DiscardInBuffer();
                    DiscardOutBuffer();
                    Write(sendBytes, 0, sendBytes.Length);
                    timer.Enabled = true;
                }
            }
            catch (Exception)
            {
            }
        }

        public void WriteModbusData(int writeaddress, ushort[] writedata)
        {
            var buff = new List<byte>();
            try
            {
                if (!IsOpen)
                    Open();
                if (IsOpen)
                {
                    var list = new List<byte>();
                    list.AddRange(new[] { (byte)Node, (byte)16 });
                    list.AddRange(BitConverter.GetBytes(Swap((ushort)writeaddress)));
                    var datacount = writedata.Length;
                    list.AddRange(BitConverter.GetBytes(Swap((ushort)datacount)));
                    list.Add((byte)(datacount * 2));
                    foreach (var writeval in writedata)
                        list.AddRange(BitConverter.GetBytes(Swap(writeval)));
                    list.AddRange(new byte[] { 0, 0 }); // место для контрольной суммы
                    var sendBytes = list.ToArray();
                    var crc = BitConverter.GetBytes(Crc(list.ToArray(), list.Count - 2));
                    sendBytes[sendBytes.Length - 2] = crc[0];
                    sendBytes[sendBytes.Length - 1] = crc[1];

                    ReceivedBytesThreshold = 1;

                    DiscardInBuffer();
                    DiscardOutBuffer();
                    Write(sendBytes, 0, sendBytes.Length);
                    timer.Enabled = true;
                }
            }
            catch (Exception)
            {
            }
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

        /// <summary>
        /// Контрольная сумма MODBUS RTU
        /// </summary>
        /// <param name="buff"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        private static ushort Crc(IList<byte> buff, int len)
        {   
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
        /// Внутренний обработчик принимаемых данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModbusSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            timer.Enabled = false;
            var buff = new List<byte>();
            while (BytesToRead > 0)
            {
                var onebyte = ReadByte();
                if (onebyte < 0) break; // буфер приёма пуст, ошибка
                buff.Add((byte)onebyte);
            }
            // проверка соответствия номера узла и это ответные данные функции чтения
            if (buff.Count > 4 && buff[0] == Node && (buff[1] & 0x7f) == Func)
            {
                var crcCalc = Crc(buff.ToArray(), buff.Count - 2);
                var crcBuff = BitConverter.ToUInt16(buff.ToArray(), buff.Count - 2);
                if (crcCalc == crcBuff)
                {
                    // данные получены правильно
                    RegCount = buff[2] / 2;
                    FetchVals = new ushort[RegCount];
                    var n = 3;
                    for (var i = 0; i < RegCount; i++)
                    {
                        var raw = new byte[2];
                        raw[0] = buff[n + 1];
                        raw[1] = buff[n];
                        FetchVals[i] = BitConverter.ToUInt16(raw, 0);
                        n += 2;
                    }
                    modbusDataReceived?.Invoke(this, new ModbusEventArgs(FetchVals));
                }
                else
                {
                    // ошибка контрольной суммы
                    modbusErrorReceived?.Invoke(this, new ModbusErrorArgs("Ошибка контрольной суммы!"));
                }
            }
            else
            // проверка соответствия номера узла и это данные подтверждения функции записи
            if (buff.Count == 8 && buff[0] == Node && (buff[1] & 0x80) == 0x00)
            {
                var crcCalc = Crc(buff.ToArray(), buff.Count - 2);
                var crcBuff = BitConverter.ToUInt16(buff.ToArray(), buff.Count - 2);
                if (crcCalc == crcBuff)
                {
                    // запись выполнена успешно
                    modbusCommandOk?.Invoke(this, new EventArgs());
                }
                else
                {
                    // ошибка контрольной суммы
                    modbusErrorReceived?.Invoke(this, new ModbusErrorArgs("Ошибка контрольной суммы!"));
                }
            }
            else
            // проверка соответствия номера узла и это подтверждение с кодом ошибки
            if (buff.Count == 5 && buff[0] == Node && (buff[1] & 0x80) == 0x80)
            {
                var crcCalc = Crc(buff.ToArray(), buff.Count - 2);
                var crcBuff = BitConverter.ToUInt16(buff.ToArray(), buff.Count - 2);
                if (crcCalc == crcBuff)
                {
                    // возвращен код ошибки MODBUS
                    modbusErrorReceived?.Invoke(this, new ModbusErrorArgs($"Код ошибки: {buff[2]}\n{DecodeErrorCode(buff[2])}"));
                }
                else
                {
                    // ошибка контрольной суммы
                    modbusErrorReceived?.Invoke(this, new ModbusErrorArgs("Ошибка контрольной суммы!"));
                }
            }
        }

        private object DecodeErrorCode(byte code)
        {
            switch (code)
            {
                case 1: return "Принятый код функции не может быть обработан.";
                case 2: return "Адрес данных, указанный в запросе, недоступен.";
                case 3: return "Значение, содержащееся в поле данных запроса, является недопустимой величиной.";
                case 4: return "Невосстанавливаемая ошибка имела место, пока ведомое устройство пыталось выполнить затребованное действие.";
                case 5: return "Ведомое устройство приняло запрос и обрабатывает его, но это требует много времени.\nЭтот ответ предохраняет ведущее устройство от генерации ошибки тайм - аута.";
                case 6: return "Ведомое устройство занято обработкой команды. Ведущее устройство должно повторить сообщение позже, когда ведомое освободится.";
                case 7: return "Ведомое устройство не может выполнить программную функцию, заданную в запросе.\nЭтот код возвращается для неуспешного программного запроса, использующего функции с номерами 13 или 14.\nВедущее устройство должно запросить диагностическую информацию или информацию об ошибках от ведомого.";
                case 8: return "Ведомое устройство при чтении расширенной памяти обнаружило ошибку паритета.\nВедущее устройство может повторить запрос, но обычно в таких случаях требуется ремонт.";
                case 10: return "Шлюз неправильно настроен или перегружен запросами.";
                case 11: return "Slave устройства нет в сети или от него нет ответа.";
                default:
                    return $"Код ошибки: {code}";
            }

        }

        private event ModbusEventHandler modbusDataReceived;

        /// <summary>
        /// Событие при получении данных MODBUS
        /// </summary>
        public event ModbusEventHandler ModbusDataReceived
        {
            add { modbusDataReceived += value; }
            remove { modbusDataReceived -= value; }
        }

        private event ModbusErrorHandler modbusErrorReceived;

        /// <summary>
        /// Событие при получении ошибки MODBUS
        /// </summary>
        public event ModbusErrorHandler ModbusErrorReceived
        {
            add { modbusErrorReceived += value; }
            remove { modbusErrorReceived -= value; }
        }

        private event EventHandler modbusTimeout;

        /// <summary>
        /// Событие при получении таймаута MODBUS
        /// </summary>
        public event EventHandler ModbusTimeout
        {
            add { modbusTimeout += value; }
            remove { modbusTimeout -= value; }
        }

        private event EventHandler modbusCommandOk;

        /// <summary>
        /// Событие при получении ошибки MODBUS
        /// </summary>
        public event EventHandler ModbusCommandOk
        {
            add { modbusCommandOk += value; }
            remove { modbusCommandOk -= value; }
        }

    }

    public class ModbusEventArgs : EventArgs
    {
        public ushort[] FetchVals { get; private set; }

        public ModbusEventArgs(ushort[] fetchVals)
        {
            FetchVals = fetchVals;
        }
    }

    public class ModbusErrorArgs : EventArgs
    {
        public string Message { get; private set; }

        public ModbusErrorArgs(string message)
        {
            Message = message;
        }
    }

    public delegate void ModbusEventHandler(object sender, ModbusEventArgs e);
    public delegate void ModbusErrorHandler(object sender, ModbusErrorArgs e);

}
