using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XucXac
{
    public partial class Form1 : Form
    {
        List<Image> num = new List<Image>();
        int dx = 5;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();

            num.Add(Properties.Resources.XX01);
            num.Add(Properties.Resources.XX02);
            num.Add(Properties.Resources.XX03);
            num.Add(Properties.Resources.XX04);
            num.Add(Properties.Resources.XX05);
            num.Add(Properties.Resources.XX06);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Title.Text = Title.Text.Substring(1) + Title.Text.Substring(0, 1);
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            int n1 = r.Next(0, 6);
            int n2 = r.Next(0, 6);
            int n3 = r.Next(0, 6);
            XucXac1.Image = num[n1];
            XucXac2.Image = num[n2];
            XucXac3.Image = num[n3];

            int total = n1 + n2 + n3 + 3;

            CountBox.Text = total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XucXac1.Image = num[0];
            XucXac2.Image = num[0];
            XucXac3.Image = num[0];
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
