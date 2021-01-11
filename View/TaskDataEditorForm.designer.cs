namespace NalivARM10
{
    partial class FormTaskDataEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbNtype = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbFactHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lbNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSetpoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDiameter = new System.Windows.Forms.Label();
            this.lbThroat = new System.Windows.Forms.Label();
            this.lbMaximum = new System.Windows.Forms.Label();
            this.lbMinimum = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbNtype
            // 
            this.cbNtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNtype.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbNtype.FormattingEnabled = true;
            this.cbNtype.Location = new System.Drawing.Point(140, 41);
            this.cbNtype.Margin = new System.Windows.Forms.Padding(2);
            this.cbNtype.Name = "cbNtype";
            this.cbNtype.Size = new System.Drawing.Size(69, 23);
            this.cbNtype.TabIndex = 2;
            this.cbNtype.SelectionChangeCommitted += new System.EventHandler(this.cbNtype_SelectionChangeCommitted);
            // 
            // btnCancel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnCancel, 2);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(215, 122);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 24);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(140, 122);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(68, 24);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ввод";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // tbFactHeight
            // 
            this.tbFactHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFactHeight.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFactHeight.Location = new System.Drawing.Point(141, 69);
            this.tbFactHeight.MaxLength = 4;
            this.tbFactHeight.Name = "tbFactHeight";
            this.tbFactHeight.Size = new System.Drawing.Size(69, 21);
            this.tbFactHeight.TabIndex = 3;
            this.tbFactHeight.TextChanged += new System.EventHandler(this.tbFactHeight_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Фактическая высота:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(47, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "Тип цистерны:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNumber
            // 
            this.tbNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumber.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNumber.Location = new System.Drawing.Point(141, 15);
            this.tbNumber.MaxLength = 8;
            this.tbNumber.Name = "tbNumber";
            this.tableLayoutPanel1.SetRowSpan(this.tbNumber, 2);
            this.tbNumber.Size = new System.Drawing.Size(69, 21);
            this.tbNumber.TabIndex = 0;
            this.tbNumber.Enter += new System.EventHandler(this.tbNumber_Enter);
            this.tbNumber.Leave += new System.EventHandler(this.tbNumber_Leave);
            this.tbNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumber_Validating);
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbNumber.Location = new System.Drawing.Point(30, 12);
            this.lbNumber.Name = "lbNumber";
            this.tableLayoutPanel1.SetRowSpan(this.lbNumber, 2);
            this.lbNumber.Size = new System.Drawing.Size(105, 27);
            this.lbNumber.TabIndex = 19;
            this.lbNumber.Text = "Номер цистерны:";
            this.lbNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(80, 93);
            this.label1.Name = "label1";
            this.tableLayoutPanel1.SetRowSpan(this.label1, 2);
            this.label1.Size = new System.Drawing.Size(55, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Задание:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSetpoint
            // 
            this.tbSetpoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSetpoint.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSetpoint.Location = new System.Drawing.Point(141, 96);
            this.tbSetpoint.MaxLength = 4;
            this.tbSetpoint.Name = "tbSetpoint";
            this.tableLayoutPanel1.SetRowSpan(this.tbSetpoint, 2);
            this.tbSetpoint.Size = new System.Drawing.Size(69, 21);
            this.tbSetpoint.TabIndex = 4;
            this.tbSetpoint.TextChanged += new System.EventHandler(this.tbSetpoint_TextChanged);
            this.tbSetpoint.Enter += new System.EventHandler(this.tbSetpoint_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(234, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "д. цистерны";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(234, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "выс. горлов.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(234, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "максимум";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(234, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "минимум";
            // 
            // lbDiameter
            // 
            this.lbDiameter.AutoSize = true;
            this.lbDiameter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDiameter.Location = new System.Drawing.Point(284, 33);
            this.lbDiameter.Name = "lbDiameter";
            this.lbDiameter.Size = new System.Drawing.Size(0, 17);
            this.lbDiameter.TabIndex = 18;
            // 
            // lbThroat
            // 
            this.lbThroat.AutoSize = true;
            this.lbThroat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbThroat.Location = new System.Drawing.Point(284, 45);
            this.lbThroat.Name = "lbThroat";
            this.lbThroat.Size = new System.Drawing.Size(0, 17);
            this.lbThroat.TabIndex = 18;
            // 
            // lbMaximum
            // 
            this.lbMaximum.AutoSize = true;
            this.lbMaximum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMaximum.Location = new System.Drawing.Point(272, 86);
            this.lbMaximum.Name = "lbMaximum";
            this.lbMaximum.Size = new System.Drawing.Size(0, 17);
            this.lbMaximum.TabIndex = 18;
            // 
            // lbMinimum
            // 
            this.lbMinimum.AutoSize = true;
            this.lbMinimum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMinimum.Location = new System.Drawing.Point(272, 98);
            this.lbMinimum.Name = "lbMinimum";
            this.lbMinimum.Size = new System.Drawing.Size(0, 17);
            this.lbMinimum.TabIndex = 18;
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbInfo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbInfo, 4);
            this.lbInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfo.Location = new System.Drawing.Point(13, 152);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(31, 13);
            this.lbInfo.TabIndex = 18;
            this.lbInfo.Text = "------";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbNumber, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOk, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbNtype, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbInfo, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbSetpoint, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbFactHeight, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 3, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 165);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // FormTaskDataEditor
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(293, 165);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbMinimum);
            this.Controls.Add(this.lbMaximum);
            this.Controls.Add(this.lbThroat);
            this.Controls.Add(this.lbDiameter);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::NalivARM10.Properties.Settings.Default, "FormTaskDataEditorLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = global::NalivARM10.Properties.Settings.Default.FormTaskDataEditorLocation;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTaskDataEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Задание налива";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTaskDataEditor_FormClosing);
            this.Load += new System.EventHandler(this.FormTaskDataEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNtype;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbFactHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSetpoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDiameter;
        private System.Windows.Forms.Label lbThroat;
        private System.Windows.Forms.Label lbMaximum;
        private System.Windows.Forms.Label lbMinimum;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}