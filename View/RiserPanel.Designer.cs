
namespace NalivARM10
{
    partial class RiserPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.chboxSelected = new System.Windows.Forms.CheckBox();
            this.riserControl1 = new NalivARM10.RiserControl(this.components);
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(94, 77);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(48, 20);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(5, 77);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(48, 20);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // chboxSelected
            // 
            this.chboxSelected.AutoSize = true;
            this.chboxSelected.Location = new System.Drawing.Point(7, 59);
            this.chboxSelected.Name = "chboxSelected";
            this.chboxSelected.Size = new System.Drawing.Size(15, 14);
            this.chboxSelected.TabIndex = 3;
            this.chboxSelected.UseVisualStyleBackColor = true;
            // 
            // riserControl1
            // 
            this.riserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riserControl1.Location = new System.Drawing.Point(0, 0);
            this.riserControl1.Margin = new System.Windows.Forms.Padding(0);
            this.riserControl1.Name = "riserControl1";
            this.riserControl1.NType = "0";
            this.riserControl1.Riser = ((uint)(0u));
            this.riserControl1.Selected = false;
            this.riserControl1.SetPoint = 0;
            this.riserControl1.Size = new System.Drawing.Size(148, 101);
            this.riserControl1.TabIndex = 0;
            this.riserControl1.Text = "riserControl1";
            // 
            // RiserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chboxSelected);
            this.Controls.Add(this.riserControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RiserPanel";
            this.Size = new System.Drawing.Size(148, 101);
            this.Load += new System.EventHandler(this.RiserPanel_Load);
            this.Enter += new System.EventHandler(this.RiserPanel_Enter);
            this.Leave += new System.EventHandler(this.RiserPanel_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RiserControl riserControl1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chboxSelected;
    }
}
