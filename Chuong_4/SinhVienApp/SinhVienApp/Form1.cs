using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVienApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(new string[] { MSSVTextBox.Text, NameTextBox.Text });
            SinhVienListView.Items.Add(item);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (SinhVienListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = SinhVienListView.SelectedItems[0];
                selectedItem.SubItems[0].Text = MSSVTextBox.Text;
                selectedItem.SubItems[1].Text = NameTextBox.Text;
            }
        }

        private void SinhVienListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SinhVienListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = SinhVienListView.SelectedItems[0];
                MSSVTextBox.Text = selectedItem.SubItems[0].Text;
                NameTextBox.Text = selectedItem.SubItems[1].Text;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
