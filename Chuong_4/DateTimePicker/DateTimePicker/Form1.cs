using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int year = Int32.Parse(YearTextBox.Text);
                int month = Int32.Parse(MonthTextBox.Text);
                int day = Int32.Parse(DayTextBox.Text);
                DateTime dateTime = new DateTime(year, month, day);
                dateTimePicker.Value = dateTime;
            }
            catch (ArgumentOutOfRangeException exc)
            {
                MessageBox.Show("Ngày không hợp lệ.");
                Console.WriteLine(exc.StackTrace);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
                return;
            }
        }

        private void UpdateDateTimePickerButton_Click(object sender, EventArgs e)
        {
            DateTime currentPick = dateTimePicker.Value;
            DayTextBox.Text = currentPick.Day.ToString();
            MonthTextBox.Text = currentPick.Month.ToString();
            YearTextBox.Text = currentPick.Year.ToString();
            DateTextBox.Text = currentPick.ToString("dd/MM/yyyy");
        }
    }
}
