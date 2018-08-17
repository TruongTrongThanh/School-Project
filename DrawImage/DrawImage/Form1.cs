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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string path = Application.StartupPath;
            Image img = Image.FromFile(path + @"\Picture.png");
            Image img2 = Image.FromFile(path + @"\Picture.png");
            img2.RotateFlip(RotateFlipType.Rotate180FlipX); // Nếu chuyển góc khác thì dò trong RotateFlipType
            int resizeNumber = 200; // 200 là số để resize nhỏ hình
            int imgWidth = img.Width - resizeNumber; 
            int imgHeight = img.Height - resizeNumber; 

            e.Graphics.DrawImage(img, 0f, 0f, imgWidth, imgHeight);
            e.Graphics.DrawImage(img2, 0f, imgHeight + 10, imgWidth, imgHeight); // Số 10 là khoảng cách trên dưới giữa 2 hình
            
            Font font = new Font("Arial", 50);
            Brush brush = new SolidBrush(Color.Red);

            int rectFWidth = ClientRectangle.Width - imgWidth + 10; // Số 10 là khoảng cách giữa 2 hình với chữ
            int rectFHeight = ClientRectangle.Height;
            RectangleF rectF = new RectangleF(new PointF(imgWidth + 10, 0f), new SizeF(rectFWidth, rectFHeight));
     
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            format.FormatFlags = StringFormatFlags.DirectionVertical;
            e.Graphics.DrawString("Hello", font, brush, rectF, format);
        }
    }
}
