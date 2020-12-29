using NalivARM10.Model;
using NalivARM10.View;
using System.Windows.Forms;

namespace NalivARM10
{
    public partial class RiserStatusControl : UserControl, IFetchUpdate
    {
        public RiserStatusControl()
        {
            InitializeComponent();
        }

        public int NodeType { get; set; }

        public event WriteData OnWrite;

        private RiserKey riserKey;

        public void UpdateData(RiserKey riserKey, ushort[] hregs)
        {
            this.riserKey = riserKey;

            if (hregs == null || hregs.Length != 61)
            {
                UpdateTimeout();
                return;
            }            
            var level = hregs[0];
            lbAnalogLevel.Text = (level > 32767 ? level - 65536 : level).ToString("0");
            lbStopCount.Text = (hregs[1] & 0xff).ToString("0");
            lbAutomatState.Text = EncodeAutomatState(hregs[5]);
            // причина последней остановки
            stopKind0.State = (hregs[2] & 0x01) > 0;        // сигнализатор аварийный
            stopKind1.State = (hregs[2] & 0x02) > 0;        // кнопка СТОП
            stopKind2.State = (hregs[2] & 0x04) > 0;        // неисправность цепи готовности
            stopKind3.State = (hregs[2] & 0x08) > 0;        // неисправность сигнализатора уровня
            stopKind4.State = (hregs[2] & 0x10) > 0;        // истекло время работы без связи
            stopKind5.State = (hregs[2] & 0x20) > 0;        // заземление отсутствует
            stopKind6.State = (hregs[2] & 0x40) > 0;        // ошибка клапана большого прохода
            stopKind7.State = (hregs[2] & 0x80) > 0;        // ошибка клапана малого прохода
            stopKind8.State = (hregs[2] & 0x0100) > 0;      // ток сигнализатора уровня минимальный (обрыв)
            stopKind9.State = (hregs[2] & 0x0200) > 0;      // ток сигнализатора уровня максимальный (к.з.)
            stopKind10.State = (hregs[2] & 0x0400) > 0;     // ток аварийного сигнализатора уровня минимальный (обрыв)
            stopKind11.State = (hregs[2] & 0x0800) > 0;     // ток аварийного сигнализатора уровня максимальный (к.з.)
            stopKind12.State = (hregs[2] & 0x1000) > 0;     // сработал датчик рабочего положения
            stopKind13.State = (hregs[2] & 0x2000) > 0;     // автоматическое завершение налива (по заданию)
            stopKind14.State = (hregs[2] & 0x4000) > 0;     // дистанционное завершение налива
            stopKind15.State = (hregs[2] & 0x8000) > 0;     // неверное завершение налива
            stopKind0.Visible = (bool) stopKind0.State;
            stopKind1.Visible = (bool) stopKind1.State;
            stopKind2.Visible = (bool) stopKind2.State;
            stopKind3.Visible = (bool) stopKind3.State;
            stopKind4.Visible = (bool) stopKind4.State;
            stopKind5.Visible = (bool) stopKind5.State;
            stopKind6.Visible = (bool) stopKind6.State;
            stopKind7.Visible = (bool) stopKind7.State;
            stopKind8.Visible = (bool) stopKind8.State;
            stopKind9.Visible = (bool) stopKind9.State;
            stopKind10.Visible = (bool) stopKind10.State;
            stopKind11.Visible = (bool) stopKind11.State;
            stopKind12.Visible = (bool) stopKind12.State;
            stopKind13.Visible = (bool) stopKind13.State;
            stopKind14.Visible = (bool) stopKind14.State;
            stopKind15.Visible = (bool) stopKind15.State;
            // текущее состояние поля
            stateStartButton.State = (hregs[3] & 0x0001) > 0;
            stateBigValve.State = (hregs[1] & 0x1000) > 0 || (hregs[3] & 0x02) > 0;
            stateSmallValve.State = (hregs[1] & 0x2000) > 0 || (hregs[3] & 0x04) > 0;
            stateReady.State = (hregs[3] & 0x0008) > 0;
            stateWorkPosition.State = (hregs[1] & 0x4000) > 0 || (hregs[3] & 0x10) > 0;
            stateCheckGround.State = !((hregs[3] & 0x20) > 0);
            stateCheckLevel.State = (hregs[3] & 0x40) > 0;
            stateHandButton.State = (hregs[3] & 0x80) > 0;
            stateAnalogLevelMin.State = (hregs[3] & 0x0400) > 0;
            stateAnalogLevelMax.State = (hregs[3] & 0x0800) > 0;
            stateAlarmLevelMin.State = (hregs[3] & 0x4000) > 0;
            stateAlarmLevelMax.State = (hregs[3] & 0x8000) > 0;
            // программное состояние
            stateAlarmLevel.State = (hregs[4] & 0x01) > 0;
            stateStopButton.State = (hregs[4] & 0x02) > 0;
            stateReadyError.State = (hregs[4] & 0x04) > 0;
            stateLevelError.State = (hregs[4] & 0x08) > 0;
            stateGroundError.State = (hregs[4] & 0x20) > 0;
            stateBigValveError.State = (hregs[4] & 0x40) > 0;
            stateSmallValveError.State = (hregs[4] & 0x80) > 0;
            commandOpenBigValve.State = (hregs[4] & 0x0100) > 0;
            commandOpenSmallValve.State = (hregs[4] & 0x0200) > 0;
            commandGreenLampOn.State = (hregs[4] & 0x4000) > 0;
            commandBlueLampOn.State = (hregs[4] & 0x8000) > 0;
        }

        public void UpdateTimeout()
        {
            lbAnalogLevel.Text = @"------";
            lbStopCount.Text = @"------";
            lbAutomatState.Text = @"------";
            // причина последней остановки
            stopKind0.State = null;
            stopKind1.State = null;
            stopKind2.State = null;
            stopKind3.State = null;
            stopKind4.State = null;
            stopKind5.State = null;
            stopKind6.State = null;
            stopKind7.State = null;
            stopKind8.State = null;
            stopKind9.State = null;
            stopKind10.State = null;
            stopKind11.State = null;
            stopKind12.State = null;
            stopKind13.State = null;
            stopKind14.State = null;
            stopKind15.State = null;
            stopKind0.Visible = false;
            stopKind1.Visible = false;
            stopKind2.Visible = false;
            stopKind3.Visible = false;
            stopKind4.Visible = false;
            stopKind5.Visible = false;
            stopKind6.Visible = false;
            stopKind7.Visible = false;
            stopKind8.Visible = false;
            stopKind9.Visible = false;
            stopKind10.Visible = false;
            stopKind11.Visible = false;
            stopKind12.Visible = false;
            stopKind13.Visible = false;
            stopKind14.Visible = false;
            stopKind15.Visible = false;
            // текущее состояние поля
            stateStartButton.State = null; 
            stateBigValve.State = null;
            stateSmallValve.State = null;
            stateReady.State = null;
            stateWorkPosition.State = null;
            stateCheckGround.State = null;
            stateCheckLevel.State = null;
            stateHandButton.State = null;
            stateAnalogLevelMin.State = null;
            stateAnalogLevelMax.State = null;
            stateAlarmLevelMin.State = null;
            stateAlarmLevelMax.State = null;
            // программное состояние
            stateAlarmLevel.State = null;
            stateStopButton.State = null;
            stateReadyError.State = null;
            stateLevelError.State = null;
            stateGroundError.State = null;
            stateBigValveError.State = null;
            stateSmallValveError.State = null;
            commandOpenBigValve.State = null;
            commandOpenSmallValve.State = null;
            commandGreenLampOn.State = null;
            commandBlueLampOn.State = null;
        }

        private static string EncodeAutomatState(int state)
        {
            switch (state)
            {
                case 0:
                    return "Сброшен";
                case 1:
                    return "Ожидание";
                case 2:
                    return "Ожидание в автономном режиме";
                case 3:
                    return "Налив малым проходом в автономном режиме";
                case 4:
                    return "Налив большим проходом в автономном режиме";
                case 5:
                    return "Налив малым проходом в автоматическом режиме";
                case 6:
                    return "Налив большим проходом в автоматическом режиме";
                case 7:
                    return "Завершение налива в автоматическом режиме";
                case 8:
                    return "Дистанционное завершение налива";
                case 9:
                    return "Налив завершён";
                default:
                    return "Неопределённое состояние: " + state;
            }
        }
    }
}
