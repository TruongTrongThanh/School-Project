using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DrawImage
{
    class RotateLabel : Label
    {
        public float Angle { get; set; }
        public Font VerticalFont { get; set; }
        public Brush Brush { get; set; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.TranslateTransform(Width / 2, Height / 2);
            pe.Graphics.RotateTransform(Angle);
            pe.Graphics.DrawString(Text, VerticalFont, Brush, 0f, 0f);
            //base.OnPaint(pe);
        }
    }
}
