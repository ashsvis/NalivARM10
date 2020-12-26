
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
            this.riserControl1 = new NalivARM10.RiserControl(this.components);
            this.SuspendLayout();
            // 
            // riserControl1
            // 
            this.riserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riserControl1.Location = new System.Drawing.Point(0, 0);
            this.riserControl1.Margin = new System.Windows.Forms.Padding(0);
            this.riserControl1.Name = "riserControl1";
            this.riserControl1.NType = "0";
            this.riserControl1.Riser = 0;
            this.riserControl1.SetPoint = 0;
            this.riserControl1.Size = new System.Drawing.Size(148, 101);
            this.riserControl1.TabIndex = 0;
            this.riserControl1.Text = "riserControl1";
            // 
            // RiserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.riserControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RiserPanel";
            this.Size = new System.Drawing.Size(148, 101);
            this.Load += new System.EventHandler(this.RiserPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RiserControl riserControl1;
    }
}
