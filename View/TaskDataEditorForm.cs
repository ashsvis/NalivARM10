using NalivARM10.Model;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace NalivARM10
{
    public partial class FormTaskDataEditor : Form
    {
        //private readonly RiserAddress _address;

        public FormTaskDataEditor(RiserKey riserKey, string number = "", string ntype = "", int factheight = 0, int setpoint = 0)
        {
            InitializeComponent();
            //TypeDataKeeper.LoadTypesData("wagtypes.xml");
            //foreach (var item in TypeDataKeeper.GetWaggonTypeItems().OrderBy(item => int.Parse(item.NType)))
            //    cbNtype.Items.Add(item);
            if (!string.IsNullOrWhiteSpace(number))
            {
                tbNumber.Text = number;
                FindWaggon(tbNumber.Text);
            }
            if (!string.IsNullOrWhiteSpace(ntype))
            {
                cbNtype.Text = ntype;
                cbNtype_SelectionChangeCommitted(null, null);
            }
            if (factheight > 0)
            {
                tbFactHeight.Text = factheight.ToString("0");
            }
            if (setpoint > 0)
            {
                tbSetpoint.Text = setpoint.ToString("0");
                UpdateMinMax(tbSetpoint);
            }

            RiserKey = riserKey;
        }

        public RiserKey RiserKey { get; set; }

        //public WaggonData GetData
        //{
        //    get
        //    {
        //        return new WaggonData
        //        {
        //            Number = tbNumber.Text,
        //            Ntype = cbNtype.Text,
        //            FactHeight = int.Parse(tbFactHeight.Text),
        //            Setpoint = int.Parse(tbSetpoint.Text)
        //        };
        //    }
        //}

        private void FormTaskDataEditor_Load(object sender, System.EventArgs e)
        {
            if (Location == Point.Empty)
                CenterToScreen();
            lbInfo.Text = "";
            if (!string.IsNullOrWhiteSpace(tbNumber.Text) &&
                !string.IsNullOrWhiteSpace(cbNtype.Text))
            {
                tbNumber.Enabled = false;
            }
            timerUpdate.Enabled = true;
        }

        private void FormTaskDataEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.None || DialogResult != DialogResult.OK) return;
            if (tbNumber.Text.Trim().Length == 8 &&
                tbNumber.Text.Trim().All(char.IsDigit))
            {
                errorProvider1.SetError(tbNumber, string.Empty);
                if (cbNtype.Text.Trim().Length > 0)
                {
                    errorProvider1.SetError(cbNtype, string.Empty);
                    if (tbFactHeight.Text.Trim().Length > 0 &&
                        tbFactHeight.Text.Trim().All(char.IsDigit))
                    {
                        errorProvider1.SetError(tbFactHeight, string.Empty);
                        if (tbSetpoint.Text.Trim().Length > 0 &&
                            tbFactHeight.Text.Trim().All(char.IsDigit))
                        {
                            errorProvider1.SetError(tbSetpoint, string.Empty);
                            lbInfo.Text = "";
                        }
                        else
                        {
                            e.Cancel = true;
                            lbInfo.Text = @"Не задан уровень налива";
                            errorProvider1.SetError(tbSetpoint, lbInfo.Text);
                        }
                    }
                    else
                    {
                        e.Cancel = true;
                        lbInfo.Text = @"Не задана фактическая высота цистерны";
                        errorProvider1.SetError(tbFactHeight, lbInfo.Text);
                    }
                }
                else
                {

                    e.Cancel = true;
                    if (!FindWaggon(tbNumber.Text))
                    {
                        lbInfo.Text = @"Не указан тип цистерны";
                        errorProvider1.SetError(cbNtype, lbInfo.Text);
                    }
                }
            }
            else
            {
                e.Cancel = true;
                lbInfo.Text = @"Укажите 8-ми значный номер цистерны";
                errorProvider1.SetError(tbNumber, lbInfo.Text);
            }
        }

        private int? _minimum, _maximum;

        public int? DeepLevel { get; set; }
        public int? WorkLevel { get; set; }
        
        private void UpdateMinMax(object sender)
        {
            if (sender == tbSetpoint && cbNtype.SelectedItem != null)
            {
                //var wt = (TypeData)cbNtype.SelectedItem;
                //int ival;
                //var factlevel = int.TryParse(tbFactHeight.Text.Trim(), out ival) ? ival : wt.Diameter + wt.Throat;
                //_minimum = DeepLevel != null ? factlevel - DeepLevel : null;
                //lbMinimum.Text = string.Format("{0}", _minimum);
                //_maximum = WorkLevel != null ? _minimum + WorkLevel : null;
                //lbMaximum.Text = string.Format("{0}", _maximum);
            }
        }

        private void cbNtype_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            //var typeItem = (TypeData)cbNtype.SelectedItem;
            //if (typeItem == null) return;
            //lbDiameter.Text = typeItem.Diameter.ToString("0");
            //lbThroat.Text = typeItem.Throat.ToString("0");
            //tbSetpoint.Text = typeItem.Deflevel.ToString("0");
            //lbInfo.Text = "";
            //UpdateMinMax(tbSetpoint);
            //errorProvider1.SetError(cbNtype, string.Empty);
        }

        private void tbNumber_Leave(object sender, System.EventArgs e)
        {
            if (!FindWaggon(tbNumber.Text))
                cbNtype.SelectedItem = null;
        }

        private bool FindWaggon(string text)
        {
            //var waggon = WaggonDataKeeper.GetWaggon(text);
            //if (waggon == null) return false;
            //cbNtype.Text = waggon.Ntype;
            //cbNtype_SelectionChangeCommitted(null, null);
            //errorProvider1.SetError(cbNtype, string.Empty);
            //lbInfo.Text = "";
            //tbFactHeight.Text = waggon.FactHeight.ToString("0");
            //cbNtype.Enabled = false;
            //tbFactHeight.Enabled = false;
            //tbSetpoint.Focus();
            //tbSetpoint.SelectAll();
            return true;
        }

        private void tbNumber_Enter(object sender, System.EventArgs e)
        {
            cbNtype.Enabled = true;
            tbFactHeight.Enabled = true;
        }

        private void tbSetpoint_Enter(object sender, System.EventArgs e)
        {
            lbMinimum.Text = "";
            lbMaximum.Text = "";
            UpdateMinMax(sender);
        }

        private void timerUpdate_Tick(object sender, System.EventArgs e)
        {
            timerUpdate.Enabled = false;
            //lock (Data.RiserNodes)
            //{
            //    var riserNode = Data.RiserNodes[_address];
            //    DeepLevel = riserNode.DeepLevel;
            //    WorkLevel = riserNode.WorkLevel;
            //}
        }

        private void tbNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.SetError(tbNumber, CheckWaggonNumber(tbNumber.Text));
        }

        private static string CheckWaggonNumber(string number)
        {
            if (number.Trim().Length != 8) return "Ожидался 8-значный номер";
            if (number.Any(ch => !char.IsDigit(ch))) return "Номер содержит нечисловые символы";
            // проверка на дублирование номера вагона в партии
            //var list = Data.Tasks.ReadSections();
            //foreach (var riserSection in list)
            //{
            //    var lastEnteredNumber = Data.Tasks.ReadString(riserSection, "Number", "");
            //    if (!lastEnteredNumber.Equals(number)) continue;
            //    var overpass = Data.Tasks.ReadString(riserSection, "Overpass", "");
            //    var way = Data.Tasks.ReadString(riserSection, "Way", "");
            //    var product = Data.GetFineProductName(Data.Tasks.ReadString(riserSection, "Product", ""));
            //    var riser = Data.Tasks.ReadString(riserSection, "Riser", "");
            //    return string.Format("Номер цистерны {0} уже используется " +
            //                         "в задании налива для стояка {1} эстакады {2}, путь {3}, продукт: {4}", 
            //                         number, riser, overpass, way, product);
            //}
            // проверка на корректность номера по контрольной сумме
            var fp = CultureInfo.GetCultureInfo("en-US");
            var sum = 0;
            var kf = new[] { 2, 1, 2, 1, 2, 1, 2 };
            for (var i = 1; i <= 7; i++)
            {
                var val = kf[i - 1] * int.Parse(number[i - 1].ToString(fp));
                if (val > 9) val = 1 + (val - 10);
                sum += val;
            }
            var lastDigit = int.Parse(number[7].ToString(fp));
            var text = (sum + lastDigit).ToString("0");
            return text.Length > 0 && text[text.Length - 1] == '0'
                ? string.Empty
                : "Некорректный номер (не сходится контрольная сумма)";
        }

        private void tbSetpoint_TextChanged(object sender, System.EventArgs e)
        {
            if (_minimum == null || _maximum == null) return;
            int setpoint;
            if (int.TryParse(tbSetpoint.Text, out setpoint))
            {
                if (setpoint >= (int) _minimum && setpoint <= (int) _maximum)
                {
                    btnOk.Enabled = true;
                    errorProvider1.SetError(tbSetpoint, "");
                }
                else
                {
                    btnOk.Enabled = false;
                    errorProvider1.SetError(tbSetpoint,
                                            setpoint < (int) _minimum
                                                ? string.Format("Заданный уровень меньше минимально возможного [{0}]",
                                                                _minimum)
                                                : string.Format("Заданный уровень больше максимально возможного [{0}]",
                                                                _maximum));
                }
            }
            else
            {
                btnOk.Enabled = false;
                errorProvider1.SetError(tbSetpoint, "Недопустимое числовое значение");
            }
        }

        /// <summary>
        /// Отмена ввода пользователем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void tbFactHeight_TextChanged(object sender, System.EventArgs e)
        {
            int diameter, throat;
            if (int.TryParse(lbDiameter.Text, out diameter) &&
                int.TryParse(lbThroat.Text, out throat))
            {
                int factheight;
                if (int.TryParse(tbFactHeight.Text, out factheight))
                {
                    btnOk.Enabled = true;
                    errorProvider1.SetError(tbFactHeight, "");
                    var height = diameter + throat;
                    if (factheight >= height*0.9 && factheight <= height*1.1)
                    {
                        btnOk.Enabled = true;
                        errorProvider1.SetError(tbFactHeight, "");                        
                    }
                    else
                    {
                        btnOk.Enabled = false;
                        errorProvider1.SetError(tbFactHeight, "Заданное значение отличается от базового более чем на 10%");                        
                    }
                }
                else
                {
                    btnOk.Enabled = false;
                    errorProvider1.SetError(tbFactHeight, "Недопустимое числовое значение");
                }
            }
            else
            {
                btnOk.Enabled = false;
                errorProvider1.SetError(tbFactHeight, "Нет высот цистерны для расчёта");
            }

        }
    }
}
