using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp
{
    public partial class Form1 : Form
    {
        Dictionary<string,string> dictionary = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dictionary.Add("student", "học sinh");
            dictionary.Add("teacher", "giáo viên");
            dictionary.Add("water", "nước");
            dictionary.Add("hat", "nón");
            dictionary.Add("fire", "lửa");
            dictionary.Add("universe", "vũ trụ");
            dictionary.Add("head", "cái đầu");
            dictionary.Add("clothes", "quần áo");
            dictionary.Add("weapon", "vũ khí");
            dictionary.Add("sun", "mặt trời");
            dictionary.Add("test", "kiểm tra");
            dictionary.Add("personal", "cá nhân");
            dictionary.Add("bottle", "chai");
            dictionary.Add("spoon", "muỗng");
            dictionary.Add("coffee", "cà phê");
            dictionary.Add("like", "thích");
            dictionary.Add("button", "cái nút");
            dictionary.Add("element", "nguyên tố");
            dictionary.Add("book", "sách");
            dictionary.Add("number", "số");
            dictionary.Add("string", "chuỗi");

            AutoCompleteStringCollection englishSource = new AutoCompleteStringCollection();
            englishSource.AddRange(dictionary.Keys.ToArray());
            textBox1.AutoCompleteCustomSource = englishSource;
            listBox1.Items.AddRange(dictionary.Keys.ToArray());

            AutoCompleteStringCollection vietnamSource = new AutoCompleteStringCollection();
            vietnamSource.AddRange(dictionary.Values.ToArray());
            textBox2.AutoCompleteCustomSource = vietnamSource;
            listBox2.Items.AddRange(dictionary.Values.ToArray());
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.Tag as string == "english")
            {
                string vietnameseWord = dictionary[listBox1.SelectedItem as string];
                richTextBox1.Text = vietnameseWord;
            }
            else
            {
                string englishWord = dictionary.FirstOrDefault(x => x.Value == listBox2.SelectedItem as string).Key;
                richTextBox2.Text = englishWord;
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (listBox1.SelectedItem != null)
                {
                    string vietnameseWord = dictionary[listBox1.SelectedItem as string];
                    richTextBox1.Text = vietnameseWord;
                }
                if (listBox2.SelectedItem != null)
                {
                    string englishWord = dictionary.FirstOrDefault(x => x.Value == listBox2.SelectedItem as string).Key;
                    richTextBox2.Text = englishWord;
                }
            }
            return base.ProcessDialogKey(keyData);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Tag as string == "english")
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (textBox.Text == listBox1.Items[i] as string)
                        listBox1.SetSelected(i, true);
                }
            }
            else
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    if (textBox.Text == listBox2.Items[i] as string)
                        listBox2.SetSelected(i, true);
                }
            }
        }
    }
}
