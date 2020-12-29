using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NalivARM10
{
    public partial class StatusControl : Control
    {
        private string caption;
        private bool? state;
        private Color lampColorNone;
        private Color lampColorOff;
        private Color lampColorOn;
        private bool captionAtRight;

        public StatusControl()
        {
            InitializeComponent();
            Initialize();
        }

        public StatusControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
            Caption = "Status text";
            LampColorNone = SystemColors.Control;
            LampColorOff = Color.Red;
            LampColorOn = Color.LightGreen;
        }

        public string Caption
        {
            get { return caption; }
            set { caption = value; Invalidate(); }
        }

        public bool? State
        {
            get { return state; }
            set { state = value; Invalidate(); }
        }

        public Color LampColorNone
        {
            get { return lampColorNone; }
            set { lampColorNone = value; Invalidate(); }
        }

        public Color LampColorOff
        {
            get { return lampColorOff; }
            set { lampColorOff = value; Invalidate(); }
        }

        public Color LampColorOn
        {
            get { return lampColorOn; }
            set { lampColorOn = value; Invalidate(); }
        }

        public bool CaptionAtRight
        {
            get { return captionAtRight; }
            set { captionAtRight = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var gr = e.Graphics;

            var rect = new RectangleF(1, 1, 18, 18);
            var trect = new RectangleF(21, 1, Width - 2, Height - 2);
            if (CaptionAtRight)
            {
                rect.Offset(Width - 21, 0);
                trect.Offset(- 40, 0);
            }
            using (var brush = new SolidBrush(State != null ?
                ((bool)State ? LampColorOn : LampColorOff) : LampColorNone))
            {
                gr.FillEllipse(brush, rect);              gr.DrawEllipse(Pens.Black, rect);
                rect.Inflate(-1, -1);
                gr.DrawEllipse(Pens.Gray, rect);
            }
            var blick = new RectangleF(rect.X + 3, rect.Y + 3, 4, 4);
            gr.FillEllipse(Brushes.White, blick);
            using (var brush = new SolidBrush(ForeColor))
            {
                using (var format = new StringFormat(StringFormatFlags.NoWrap))
                {
                    format.LineAlignment = StringAlignment.Center;
                    format.Alignment = CaptionAtRight ? StringAlignment.Far : StringAlignment.Near;
                    gr.DrawString(Caption, Font, brush, trect, format);
                }
            }
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Invalidate();
        }
    }
}
