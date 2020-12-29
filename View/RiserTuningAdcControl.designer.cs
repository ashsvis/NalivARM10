namespace NalivARM10
{
	partial class RiserTuningAdcControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRestoreADC0 = new System.Windows.Forms.Button();
            this.btnEEPROMADC0 = new System.Windows.Forms.Button();
            this.btnSaveADC0 = new System.Windows.Forms.Button();
            this.btnCopyADC0 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbHR22 = new System.Windows.Forms.Label();
            this.btnSaveHR28 = new System.Windows.Forms.Button();
            this.lbHR24 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbHR26 = new System.Windows.Forms.Label();
            this.edHR26 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lbHR14_0 = new System.Windows.Forms.Label();
            this.cbHR14_0 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbHR28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lbHR29 = new System.Windows.Forms.Label();
            this.btnSaveHR29 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHR23 = new System.Windows.Forms.Label();
            this.btnSaveHR2A = new System.Windows.Forms.Button();
            this.lbHR25 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbHR27 = new System.Windows.Forms.Label();
            this.edHR27 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbHR14_4 = new System.Windows.Forms.Label();
            this.cbHR14_4 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRestoreADC1 = new System.Windows.Forms.Button();
            this.btnEEPROMADC1 = new System.Windows.Forms.Button();
            this.btnSaveADC1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbHR2A = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbHR2B = new System.Windows.Forms.Label();
            this.btnSaveHR2B = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.btnCopyADC1 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.btnCopyFromStorage = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel1, 5);
            this.flowLayoutPanel1.Controls.Add(this.btnRestoreADC0);
            this.flowLayoutPanel1.Controls.Add(this.btnEEPROMADC0);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveADC0);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(62, 167);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(304, 31);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnRestoreADC0
            // 
            this.btnRestoreADC0.Enabled = false;
            this.btnRestoreADC0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRestoreADC0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestoreADC0.Location = new System.Drawing.Point(7, 2);
            this.btnRestoreADC0.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.btnRestoreADC0.Name = "btnRestoreADC0";
            this.btnRestoreADC0.Size = new System.Drawing.Size(102, 27);
            this.btnRestoreADC0.TabIndex = 6;
            this.btnRestoreADC0.Text = "Восстановить";
            this.btnRestoreADC0.UseVisualStyleBackColor = true;
            this.btnRestoreADC0.Click += new System.EventHandler(this.BtnRestoreAdc0Click);
            // 
            // btnEEPROMADC0
            // 
            this.btnEEPROMADC0.Enabled = false;
            this.btnEEPROMADC0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEEPROMADC0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEEPROMADC0.Location = new System.Drawing.Point(123, 2);
            this.btnEEPROMADC0.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.btnEEPROMADC0.Name = "btnEEPROMADC0";
            this.btnEEPROMADC0.Size = new System.Drawing.Size(66, 27);
            this.btnEEPROMADC0.TabIndex = 7;
            this.btnEEPROMADC0.Text = "EEPROM";
            this.btnEEPROMADC0.UseVisualStyleBackColor = true;
            this.btnEEPROMADC0.Click += new System.EventHandler(this.BtnEepromadc0Click);
            // 
            // btnSaveADC0
            // 
            this.btnSaveADC0.Enabled = false;
            this.btnSaveADC0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveADC0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveADC0.Location = new System.Drawing.Point(203, 2);
            this.btnSaveADC0.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.btnSaveADC0.Name = "btnSaveADC0";
            this.btnSaveADC0.Size = new System.Drawing.Size(94, 27);
            this.btnSaveADC0.TabIndex = 8;
            this.btnSaveADC0.Text = "Установить";
            this.btnSaveADC0.UseVisualStyleBackColor = true;
            this.btnSaveADC0.Click += new System.EventHandler(this.BtnSaveAdc0Click);
            // 
            // btnCopyADC0
            // 
            this.btnCopyADC0.Enabled = false;
            this.btnCopyADC0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCopyADC0.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopyADC0.Location = new System.Drawing.Point(23, 2);
            this.btnCopyADC0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyADC0.Name = "btnCopyADC0";
            this.btnCopyADC0.Size = new System.Drawing.Size(81, 19);
            this.btnCopyADC0.TabIndex = 3;
            this.btnCopyADC0.Text = "копировать>>>";
            this.btnCopyADC0.UseVisualStyleBackColor = true;
            this.btnCopyADC0.Click += new System.EventHandler(this.BtnCopyAdc0Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(110, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "W";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "R";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbHR22, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSaveHR28, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbHR24, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbHR26, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.edHR26, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbHR14_0, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.cbHR14_0, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label21, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label15, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbHR28, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label23, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbHR29, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSaveHR29, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(428, 202);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Код на выходе ADC:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR22
            // 
            this.lbHR22.AutoSize = true;
            this.lbHR22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR22.Location = new System.Drawing.Point(137, 0);
            this.lbHR22.Name = "lbHR22";
            this.lbHR22.Size = new System.Drawing.Size(65, 18);
            this.lbHR22.TabIndex = 3;
            this.lbHR22.Text = "------";
            this.lbHR22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lbHR22, "HR22 - код ADC канала 0");
            // 
            // btnSaveHR28
            // 
            this.btnSaveHR28.AutoSize = true;
            this.btnSaveHR28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveHR28.Enabled = false;
            this.btnSaveHR28.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveHR28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveHR28.Location = new System.Drawing.Point(343, 20);
            this.btnSaveHR28.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.btnSaveHR28.Name = "btnSaveHR28";
            this.btnSaveHR28.Size = new System.Drawing.Size(78, 29);
            this.btnSaveHR28.TabIndex = 0;
            this.btnSaveHR28.Text = "Установить";
            this.btnSaveHR28.UseVisualStyleBackColor = true;
            this.btnSaveHR28.Click += new System.EventHandler(this.BtnSaveHr28Click);
            // 
            // lbHR24
            // 
            this.lbHR24.AutoSize = true;
            this.lbHR24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR24.Location = new System.Drawing.Point(339, 0);
            this.lbHR24.Name = "lbHR24";
            this.lbHR24.Size = new System.Drawing.Size(86, 18);
            this.lbHR24.TabIndex = 3;
            this.lbHR24.Text = "------";
            this.lbHR24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lbHR24, "HR24 - величина тока канала 0");
            // 
            // label17
            // 
            this.label17.AutoEllipsis = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label17, 3);
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(3, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(227, 18);
            this.label17.TabIndex = 3;
            this.label17.Text = "Период выборки (мс):";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR26
            // 
            this.lbHR26.AutoSize = true;
            this.lbHR26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR26.Location = new System.Drawing.Point(242, 112);
            this.lbHR26.Name = "lbHR26";
            this.lbHR26.Size = new System.Drawing.Size(91, 24);
            this.lbHR26.TabIndex = 3;
            this.lbHR26.Text = "------";
            this.lbHR26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lbHR26, "HR26 - период выборки отсчетов канала ADC0");
            // 
            // edHR26
            // 
            this.edHR26.Location = new System.Drawing.Point(336, 113);
            this.edHR26.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.edHR26.Name = "edHR26";
            this.edHR26.Size = new System.Drawing.Size(92, 23);
            this.edHR26.TabIndex = 4;
            this.edHR26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoEllipsis = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label19, 3);
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(3, 136);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(227, 18);
            this.label19.TabIndex = 3;
            this.label19.Text = "Фильтр:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR14_0
            // 
            this.lbHR14_0.AutoSize = true;
            this.lbHR14_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR14_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR14_0.Location = new System.Drawing.Point(242, 136);
            this.lbHR14_0.Name = "lbHR14_0";
            this.lbHR14_0.Size = new System.Drawing.Size(91, 24);
            this.lbHR14_0.TabIndex = 3;
            this.lbHR14_0.Text = "------";
            this.lbHR14_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lbHR14_0, "HR14.0 - разрешение фильтра выборки отсчетов канала ADC0");
            // 
            // cbHR14_0
            // 
            this.cbHR14_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHR14_0.FormattingEnabled = true;
            this.cbHR14_0.Items.AddRange(new object[] {
            "Отключен",
            "Включен"});
            this.cbHR14_0.Location = new System.Drawing.Point(336, 137);
            this.cbHR14_0.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.cbHR14_0.Name = "cbHR14_0";
            this.cbHR14_0.Size = new System.Drawing.Size(92, 23);
            this.cbHR14_0.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoEllipsis = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label21, 3);
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(3, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(233, 33);
            this.label21.TabIndex = 3;
            this.label21.Text = "Уровень 4 mA на входе:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoEllipsis = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label15, 2);
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(208, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 18);
            this.label15.TabIndex = 3;
            this.label15.Text = "Ток на входе (mA):";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR28
            // 
            this.lbHR28.AutoSize = true;
            this.lbHR28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR28.Location = new System.Drawing.Point(242, 18);
            this.lbHR28.Name = "lbHR28";
            this.lbHR28.Size = new System.Drawing.Size(91, 33);
            this.lbHR28.TabIndex = 3;
            this.lbHR28.Text = "------";
            this.lbHR28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lbHR28, "HR28 - код канала ADC0, соответствующий току 4 mA на входе");
            // 
            // label23
            // 
            this.label23.AutoEllipsis = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label23, 3);
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(3, 51);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(233, 33);
            this.label23.TabIndex = 3;
            this.label23.Text = "Уровень 20 mA на входе:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR29
            // 
            this.lbHR29.AutoSize = true;
            this.lbHR29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR29.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR29.Location = new System.Drawing.Point(242, 51);
            this.lbHR29.Name = "lbHR29";
            this.lbHR29.Size = new System.Drawing.Size(91, 33);
            this.lbHR29.TabIndex = 3;
            this.lbHR29.Text = "------";
            this.lbHR29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lbHR29, "HR29 - код канала ADC0, соответствующий току 20 mA на входе");
            // 
            // btnSaveHR29
            // 
            this.btnSaveHR29.AutoSize = true;
            this.btnSaveHR29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveHR29.Enabled = false;
            this.btnSaveHR29.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveHR29.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveHR29.Location = new System.Drawing.Point(343, 53);
            this.btnSaveHR29.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.btnSaveHR29.Name = "btnSaveHR29";
            this.btnSaveHR29.Size = new System.Drawing.Size(78, 29);
            this.btnSaveHR29.TabIndex = 1;
            this.btnSaveHR29.Text = "Установить";
            this.btnSaveHR29.UseVisualStyleBackColor = true;
            this.btnSaveHR29.Click += new System.EventHandler(this.BtnSaveHr29Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel2, 5);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.btnCopyADC0);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(275, 86);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(150, 24);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(441, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Канал 0 (сигнализатор уровня)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 237);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(441, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Канал 1 (сигнализатор аварийный)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbHR23, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveHR2A, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbHR25, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbHR27, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.edHR27, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbHR14_4, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbHR14_4, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbHR2A, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label25, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbHR2B, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveHR2B, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(428, 202);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Код на выходе ADC:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR23
            // 
            this.lbHR23.AutoSize = true;
            this.lbHR23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR23.Location = new System.Drawing.Point(139, 0);
            this.lbHR23.Name = "lbHR23";
            this.lbHR23.Size = new System.Drawing.Size(65, 18);
            this.lbHR23.TabIndex = 3;
            this.lbHR23.Text = "------";
            this.lbHR23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lbHR23, "HR23 - код ADC канала 1");
            // 
            // btnSaveHR2A
            // 
            this.btnSaveHR2A.AutoSize = true;
            this.btnSaveHR2A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveHR2A.Enabled = false;
            this.btnSaveHR2A.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveHR2A.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveHR2A.Location = new System.Drawing.Point(343, 20);
            this.btnSaveHR2A.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.btnSaveHR2A.Name = "btnSaveHR2A";
            this.btnSaveHR2A.Size = new System.Drawing.Size(78, 29);
            this.btnSaveHR2A.TabIndex = 1;
            this.btnSaveHR2A.Text = "Установить";
            this.btnSaveHR2A.UseVisualStyleBackColor = true;
            this.btnSaveHR2A.Click += new System.EventHandler(this.BtnSaveHr2AClick);
            // 
            // lbHR25
            // 
            this.lbHR25.AutoSize = true;
            this.lbHR25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR25.Location = new System.Drawing.Point(339, 0);
            this.lbHR25.Name = "lbHR25";
            this.lbHR25.Size = new System.Drawing.Size(86, 18);
            this.lbHR25.TabIndex = 3;
            this.lbHR25.Text = "------";
            this.lbHR25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lbHR25, "HR25 - величина тока канала 1");
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label6, 3);
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Период выборки (мс):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR27
            // 
            this.lbHR27.AutoSize = true;
            this.lbHR27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR27.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR27.Location = new System.Drawing.Point(242, 112);
            this.lbHR27.Name = "lbHR27";
            this.lbHR27.Size = new System.Drawing.Size(91, 24);
            this.lbHR27.TabIndex = 3;
            this.lbHR27.Text = "------";
            this.lbHR27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lbHR27, "HR27 - период выборки отсчетов канала ADC1");
            // 
            // edHR27
            // 
            this.edHR27.Location = new System.Drawing.Point(336, 113);
            this.edHR27.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.edHR27.Name = "edHR27";
            this.edHR27.Size = new System.Drawing.Size(92, 23);
            this.edHR27.TabIndex = 4;
            this.edHR27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label8, 3);
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Фильтр:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR14_4
            // 
            this.lbHR14_4.AutoSize = true;
            this.lbHR14_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR14_4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR14_4.Location = new System.Drawing.Point(242, 136);
            this.lbHR14_4.Name = "lbHR14_4";
            this.lbHR14_4.Size = new System.Drawing.Size(91, 24);
            this.lbHR14_4.TabIndex = 3;
            this.lbHR14_4.Text = "------";
            this.lbHR14_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lbHR14_4, "HR14.4 - разрешение фильтра выборки отсчетов канала ADC1");
            // 
            // cbHR14_4
            // 
            this.cbHR14_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHR14_4.FormattingEnabled = true;
            this.cbHR14_4.Items.AddRange(new object[] {
            "Отключен",
            "Включен"});
            this.cbHR14_4.Location = new System.Drawing.Point(336, 137);
            this.cbHR14_4.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.cbHR14_4.Name = "cbHR14_4";
            this.cbHR14_4.Size = new System.Drawing.Size(92, 23);
            this.cbHR14_4.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel3, 5);
            this.flowLayoutPanel3.Controls.Add(this.btnRestoreADC1);
            this.flowLayoutPanel3.Controls.Add(this.btnEEPROMADC1);
            this.flowLayoutPanel3.Controls.Add(this.btnSaveADC1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(62, 167);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(304, 31);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // btnRestoreADC1
            // 
            this.btnRestoreADC1.Enabled = false;
            this.btnRestoreADC1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRestoreADC1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestoreADC1.Location = new System.Drawing.Point(7, 2);
            this.btnRestoreADC1.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.btnRestoreADC1.Name = "btnRestoreADC1";
            this.btnRestoreADC1.Size = new System.Drawing.Size(102, 27);
            this.btnRestoreADC1.TabIndex = 6;
            this.btnRestoreADC1.Text = "Восстановить";
            this.btnRestoreADC1.UseVisualStyleBackColor = true;
            this.btnRestoreADC1.Click += new System.EventHandler(this.BtnRestoreAdc1Click);
            // 
            // btnEEPROMADC1
            // 
            this.btnEEPROMADC1.Enabled = false;
            this.btnEEPROMADC1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEEPROMADC1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEEPROMADC1.Location = new System.Drawing.Point(123, 2);
            this.btnEEPROMADC1.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.btnEEPROMADC1.Name = "btnEEPROMADC1";
            this.btnEEPROMADC1.Size = new System.Drawing.Size(66, 27);
            this.btnEEPROMADC1.TabIndex = 7;
            this.btnEEPROMADC1.Text = "EEPROM";
            this.btnEEPROMADC1.UseVisualStyleBackColor = true;
            this.btnEEPROMADC1.Click += new System.EventHandler(this.BtnEepromadc1Click);
            // 
            // btnSaveADC1
            // 
            this.btnSaveADC1.Enabled = false;
            this.btnSaveADC1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveADC1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveADC1.Location = new System.Drawing.Point(203, 2);
            this.btnSaveADC1.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.btnSaveADC1.Name = "btnSaveADC1";
            this.btnSaveADC1.Size = new System.Drawing.Size(94, 27);
            this.btnSaveADC1.TabIndex = 8;
            this.btnSaveADC1.Text = "Установить";
            this.btnSaveADC1.UseVisualStyleBackColor = true;
            this.btnSaveADC1.Click += new System.EventHandler(this.BtnSaveAdc1Click);
            // 
            // label12
            // 
            this.label12.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label12, 3);
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 33);
            this.label12.TabIndex = 3;
            this.label12.Text = "Уровень 4 mA на входе:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label13, 2);
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(210, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "Ток на входе (mA):";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR2A
            // 
            this.lbHR2A.AutoSize = true;
            this.lbHR2A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR2A.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR2A.Location = new System.Drawing.Point(242, 18);
            this.lbHR2A.Name = "lbHR2A";
            this.lbHR2A.Size = new System.Drawing.Size(91, 33);
            this.lbHR2A.TabIndex = 3;
            this.lbHR2A.Text = "------";
            this.lbHR2A.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lbHR2A, "HR2A - код канала ADC1, соответствующий току 4 mA на входе");
            // 
            // label25
            // 
            this.label25.AutoEllipsis = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label25, 3);
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(3, 51);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(233, 33);
            this.label25.TabIndex = 3;
            this.label25.Text = "Уровень 20 mA на входе:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR2B
            // 
            this.lbHR2B.AutoSize = true;
            this.lbHR2B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR2B.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR2B.Location = new System.Drawing.Point(242, 51);
            this.lbHR2B.Name = "lbHR2B";
            this.lbHR2B.Size = new System.Drawing.Size(91, 33);
            this.lbHR2B.TabIndex = 3;
            this.lbHR2B.Text = "------";
            this.lbHR2B.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lbHR2B, "HR2B - код канала ADC1, соответствующий току 20 mA на входе");
            // 
            // btnSaveHR2B
            // 
            this.btnSaveHR2B.AutoSize = true;
            this.btnSaveHR2B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveHR2B.Enabled = false;
            this.btnSaveHR2B.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveHR2B.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveHR2B.Location = new System.Drawing.Point(343, 53);
            this.btnSaveHR2B.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.btnSaveHR2B.Name = "btnSaveHR2B";
            this.btnSaveHR2B.Size = new System.Drawing.Size(78, 29);
            this.btnSaveHR2B.TabIndex = 2;
            this.btnSaveHR2B.Text = "Установить";
            this.btnSaveHR2B.UseVisualStyleBackColor = true;
            this.btnSaveHR2B.Click += new System.EventHandler(this.BtnSaveHr2BClick);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel4, 5);
            this.flowLayoutPanel4.Controls.Add(this.label27);
            this.flowLayoutPanel4.Controls.Add(this.btnCopyADC1);
            this.flowLayoutPanel4.Controls.Add(this.label28);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(275, 86);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(150, 24);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(3, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 24);
            this.label27.TabIndex = 9;
            this.label27.Text = "R";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopyADC1
            // 
            this.btnCopyADC1.Enabled = false;
            this.btnCopyADC1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCopyADC1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopyADC1.Location = new System.Drawing.Point(23, 2);
            this.btnCopyADC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyADC1.Name = "btnCopyADC1";
            this.btnCopyADC1.Size = new System.Drawing.Size(81, 19);
            this.btnCopyADC1.TabIndex = 3;
            this.btnCopyADC1.Text = "копировать>>>";
            this.btnCopyADC1.UseVisualStyleBackColor = true;
            this.btnCopyADC1.Click += new System.EventHandler(this.BtnCopyAdc1Click);
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(110, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 24);
            this.label28.TabIndex = 11;
            this.label28.Text = "W";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopyFromStorage
            // 
            this.btnCopyFromStorage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCopyFromStorage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopyFromStorage.Location = new System.Drawing.Point(12, 469);
            this.btnCopyFromStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyFromStorage.Name = "btnCopyFromStorage";
            this.btnCopyFromStorage.Size = new System.Drawing.Size(180, 22);
            this.btnCopyFromStorage.TabIndex = 2;
            this.btnCopyFromStorage.TabStop = false;
            this.btnCopyFromStorage.Text = "копировать из архива>>>";
            this.btnCopyFromStorage.UseVisualStyleBackColor = true;
            this.btnCopyFromStorage.Visible = false;
            this.btnCopyFromStorage.Click += new System.EventHandler(this.BtnCopyFromStorageClick);
            // 
            // RiserTuningAdcControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCopyFromStorage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "RiserTuningAdcControl";
            this.Size = new System.Drawing.Size(454, 468);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btnCopyFromStorage;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Button btnCopyADC1;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		private System.Windows.Forms.Button btnSaveHR2B;
		private System.Windows.Forms.Label lbHR2B;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Button btnSaveADC1;
		private System.Windows.Forms.Button btnEEPROMADC1;
		private System.Windows.Forms.Button btnRestoreADC1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.ComboBox cbHR14_4;
		private System.Windows.Forms.TextBox edHR27;
		private System.Windows.Forms.Button btnSaveHR2A;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Button btnSaveHR29;
		private System.Windows.Forms.Label lbHR29;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label lbHR28;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.ComboBox cbHR14_0;
		private System.Windows.Forms.Label lbHR14_0;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox edHR26;
		private System.Windows.Forms.Label lbHR26;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label lbHR24;
		private System.Windows.Forms.Button btnSaveHR28;
		private System.Windows.Forms.Label lbHR22;
		private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopyADC0;
		private System.Windows.Forms.Button btnSaveADC0;
		private System.Windows.Forms.Button btnEEPROMADC0;
		private System.Windows.Forms.Button btnRestoreADC0;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label lbHR2A;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lbHR14_4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbHR27;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbHR25;
		private System.Windows.Forms.Label lbHR23;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
	}
}
