namespace NalivARM10
{
	partial class RiserTuningLinkControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.lbParity = new System.Windows.Forms.Label();
            this.lbHR38 = new System.Windows.Forms.Label();
            this.lbModbus = new System.Windows.Forms.Label();
            this.edHR38 = new System.Windows.Forms.TextBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.edAddress = new System.Windows.Forms.TextBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbHR3A = new System.Windows.Forms.Label();
            this.lbHR3B = new System.Windows.Forms.Label();
            this.lbHR3C = new System.Windows.Forms.Label();
            this.btnCopyFromStorage = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbAddress, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbBaudRate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbParity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbHR38, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbModbus, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.edHR38, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbParity, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.edAddress, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbBaudRate, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 120);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адрес устройства (1..247):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Скорость обмена:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Паритет:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Тайм-аут передачи (мкс):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Тип кадров Modbus:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoEllipsis = true;
            this.lbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddress.Location = new System.Drawing.Point(176, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(66, 24);
            this.lbAddress.TabIndex = 3;
            this.lbAddress.Text = "------";
            this.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoEllipsis = true;
            this.lbBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBaudRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBaudRate.Location = new System.Drawing.Point(176, 24);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(66, 24);
            this.lbBaudRate.TabIndex = 3;
            this.lbBaudRate.Text = "------";
            this.lbBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbParity
            // 
            this.lbParity.AutoEllipsis = true;
            this.lbParity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbParity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbParity.Location = new System.Drawing.Point(176, 48);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(66, 24);
            this.lbParity.TabIndex = 3;
            this.lbParity.Text = "------";
            this.lbParity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR38
            // 
            this.lbHR38.AutoEllipsis = true;
            this.lbHR38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR38.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR38.Location = new System.Drawing.Point(176, 72);
            this.lbHR38.Name = "lbHR38";
            this.lbHR38.Size = new System.Drawing.Size(66, 24);
            this.lbHR38.TabIndex = 3;
            this.lbHR38.Text = "------";
            this.lbHR38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbModbus
            // 
            this.lbModbus.AutoEllipsis = true;
            this.lbModbus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbModbus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbModbus.Location = new System.Drawing.Point(176, 96);
            this.lbModbus.Name = "lbModbus";
            this.lbModbus.Size = new System.Drawing.Size(66, 22);
            this.lbModbus.TabIndex = 3;
            this.lbModbus.Text = "------";
            this.lbModbus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edHR38
            // 
            this.edHR38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edHR38.Location = new System.Drawing.Point(245, 73);
            this.edHR38.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.edHR38.Name = "edHR38";
            this.edHR38.Size = new System.Drawing.Size(103, 23);
            this.edHR38.TabIndex = 4;
            this.edHR38.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbParity
            // 
            this.cbParity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbParity.Location = new System.Drawing.Point(245, 49);
            this.cbParity.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(103, 23);
            this.cbParity.TabIndex = 3;
            // 
            // edAddress
            // 
            this.edAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edAddress.Location = new System.Drawing.Point(245, 1);
            this.edAddress.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.edAddress.Name = "edAddress";
            this.edAddress.Size = new System.Drawing.Size(103, 23);
            this.edAddress.TabIndex = 1;
            this.edAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400"});
            this.cbBaudRate.Location = new System.Drawing.Point(245, 25);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(103, 23);
            this.cbBaudRate.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(254, 156);
            this.btnSave.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Установить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(336, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "W";
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopy.Location = new System.Drawing.Point(244, 6);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(78, 19);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "копировать>>>";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopyClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(214, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "R";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.02519F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.97481F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbHR3A, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbHR3B, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbHR3C, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 189);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 72);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Версия программного обеспечения:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 22);
            this.label10.TabIndex = 3;
            this.label10.Text = "Версия платы управления:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(239, 22);
            this.label11.TabIndex = 3;
            this.label11.Text = "Номер платы управления:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR3A
            // 
            this.lbHR3A.AutoEllipsis = true;
            this.lbHR3A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR3A.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR3A.Location = new System.Drawing.Point(248, 0);
            this.lbHR3A.Name = "lbHR3A";
            this.lbHR3A.Size = new System.Drawing.Size(99, 22);
            this.lbHR3A.TabIndex = 3;
            this.lbHR3A.Text = "------";
            this.lbHR3A.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbHR3B
            // 
            this.lbHR3B.AutoEllipsis = true;
            this.lbHR3B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR3B.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR3B.Location = new System.Drawing.Point(248, 22);
            this.lbHR3B.Name = "lbHR3B";
            this.lbHR3B.Size = new System.Drawing.Size(99, 22);
            this.lbHR3B.TabIndex = 3;
            this.lbHR3B.Text = "------";
            this.lbHR3B.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbHR3C
            // 
            this.lbHR3C.AutoEllipsis = true;
            this.lbHR3C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHR3C.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR3C.Location = new System.Drawing.Point(248, 44);
            this.lbHR3C.Name = "lbHR3C";
            this.lbHR3C.Size = new System.Drawing.Size(99, 22);
            this.lbHR3C.TabIndex = 3;
            this.lbHR3C.Text = "------";
            this.lbHR3C.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCopyFromStorage
            // 
            this.btnCopyFromStorage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCopyFromStorage.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopyFromStorage.Location = new System.Drawing.Point(64, 5);
            this.btnCopyFromStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyFromStorage.Name = "btnCopyFromStorage";
            this.btnCopyFromStorage.Size = new System.Drawing.Size(136, 19);
            this.btnCopyFromStorage.TabIndex = 0;
            this.btnCopyFromStorage.TabStop = false;
            this.btnCopyFromStorage.Text = "копировать из архива>>>";
            this.btnCopyFromStorage.UseVisualStyleBackColor = true;
            this.btnCopyFromStorage.Visible = false;
            this.btnCopyFromStorage.Click += new System.EventHandler(this.BtnCopyFromStorageClick);
            // 
            // RiserTuningLinkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCopyFromStorage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "RiserTuningLinkControl";
            this.Size = new System.Drawing.Size(364, 268);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btnCopyFromStorage;
		private System.Windows.Forms.Label lbHR3C;
		private System.Windows.Forms.Label lbHR3B;
		private System.Windows.Forms.Label lbHR3A;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.TextBox edAddress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbParity;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox edHR38;
		private System.Windows.Forms.Label lbModbus;
		private System.Windows.Forms.Label lbHR38;
		private System.Windows.Forms.Label lbParity;
		private System.Windows.Forms.Label lbBaudRate;
		private System.Windows.Forms.Label lbAddress;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
