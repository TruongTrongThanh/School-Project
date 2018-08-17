using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DrawImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image img = Properties.Resources.SomeImage;
            int boundWidth = img.Width - 200;
            int boundHeight = img.Height - 200;

            PictureBox picBox2 = new PictureBox();
            picBox2.SetBounds(0, 0,boundWidth, boundHeight);
            picBox2.SizeMode = PictureBoxSizeMode.Zoom;
            picBox2.Image = img;

            Image img2 = Properties.Resources.SomeImage;

            PictureBox picBox = new PictureBox();
            picBox.SetBounds(0, boundHeight + 10, boundWidth, boundHeight);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            img2.RotateFlip(RotateFlipType.Rotate180FlipX);
            picBox.Image = img2;

            RotateLabel label = new RotateLabel();
            label.Angle = 90;
            label.Text = "Hello";
            label.VerticalFont = new Font("Arial", 50, FontStyle.Bold);
            label.Brush = new HatchBrush(HatchStyle.DarkHorizontal, Color.Red, Color.Bisque);
            label.Location = new Point(boundWidth + 100, 0);
            label.Size = new Size(200, 400);

            Controls.Add(picBox);
            Controls.Add(picBox2);
            Controls.Add(label);
        }
    }
}
