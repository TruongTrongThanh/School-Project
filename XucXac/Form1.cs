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
        int currentMoney = 0;
        string path = Application.StartupPath;
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Title.Text = Title.Text.Substring(1) + Title.Text.Substring(0, 1);
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            if (WagerComboBox.SelectedItem == null || (BetRadioButton11_18.Checked == false && BetRadioButton3_10.Checked == false))
            { 
                MessageBox.Show("Bạn chưa đặt cược hoặc chọn số muốn đặt cược!");
                return;
            }
            int n1 = r.Next(1, 7);
            int n2 = r.Next(1, 7);
            int n3 = r.Next(1, 7);
      
            XucXac1.Image = Image.FromFile(path + @"\XX0" + n1 + ".png");
            XucXac2.Image = Image.FromFile(path + @"\XX0" + n2 + ".png"); 
            XucXac3.Image = Image.FromFile(path + @"\XX0" + n3 + ".png"); 

            int total = n1 + n2 + n3 + 3;

            if (BetRadioButton3_10.Checked == true)
            {
                if (total <= 10)
                {
                    currentMoney += Int32.Parse(WagerComboBox.SelectedItem.ToString());
                } 
                else
                {
                    currentMoney -= Int32.Parse(WagerComboBox.SelectedItem.ToString());
                }
            }
            else
            {
                if (total > 10 && total <= 18)
                {
                    currentMoney += Int32.Parse(WagerComboBox.SelectedItem.ToString());
                }
                else
                {
                    currentMoney -= Int32.Parse(WagerComboBox.SelectedItem.ToString());
                }
            }

            MoneyBox.Text = currentMoney.ToString();
            CountBox.Text = total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XucXac1.Image = Image.FromFile(path + @"\XX01.png");
            XucXac2.Image = Image.FromFile(path + @"\XX01.png");
            XucXac3.Image = Image.FromFile(path + @"\XX01.png");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
