using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorApp
{
    public partial class Form1 : Form
    {

        int red, blue, green = 0;

        public Form1()
        {
            InitializeComponent();
            RedTextBox.Text = red.ToString();
            BlueTextBox.Text = blue.ToString();
            GreenTextBox.Text = green.ToString();
        }

        private void ScrollBar_ValueChanged(object sender, EventArgs e)
        {
            HScrollBar scrollBar = sender as HScrollBar;
            if (scrollBar.Tag as string == "red")
            {
                red = scrollBar.Value;
                RedTextBox.Text = red.ToString();
            }
            if (scrollBar.Tag as string == "blue")
            {
                blue = scrollBar.Value;
                BlueTextBox.Text = blue.ToString();
            }
            if (scrollBar.Tag as string == "green")
            {
                green = scrollBar.Value;
                GreenTextBox.Text = green.ToString();
            }
            ChangeColor();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "") return;
            try
            {
                if (Int32.TryParse(textBox.Text, out int value))
                {
                    if (value > 255 || value < 0)
                        throw new FormatException("Chỉ được nhập từ 0-255");
                }
                else
                    throw new FormatException("Nhập sai dữ liệu.");
                if (textBox.Tag as string == "red")
                {
                    red = value;
                    RedScrollBar.Value = value;
                }
                if (textBox.Tag as string == "blue")
                {
                    blue = value;
                    BlueScrollBar.Value = value;
                }
                if (textBox.Tag as string == "green")
                {
                    green = value;
                    GreenScrollBar.Value = value;
                }
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
            ChangeColor();
        }

        private void ChangeColor()
        {
            ColorBox.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
