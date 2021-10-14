using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._09._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int old_b = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string s = maskedTextBox1.Text;
            MessageBox.Show("");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                MessageBox.Show("Правильно!");
            }
            else
            {
                MessageBox.Show("Неправильно!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                MessageBox.Show("Правильно!");
            }
            else
            {
                MessageBox.Show("Неправильно!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true && checkBox3.Checked == true&& checkBox2.Checked != true)
            {
                MessageBox.Show("Правильно");
            }
            else
            {
                MessageBox.Show("неправильно");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ничего не выбрано");

            }
            else
            {
                int n = listBox1.SelectedIndex;//номер строки, которая выбрана
                string s = listBox1.Items[n].ToString();
                MessageBox.Show(s);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Ничего не выбрано");

            }
            else
            {
                int n = comboBox1.SelectedIndex;//номер строки, которая выбрана
                string s = comboBox1.Items[n].ToString();
                MessageBox.Show(s);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s1 = "";
            string s2 = "";
            for(int i=0; i<checkedListBox1.Items.Count; i++)
            {
                s1 += checkedListBox1.Items[i].ToString() + "";
            }
            MessageBox.Show(s1);
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                s2 += checkedListBox1.CheckedItems[i].ToString();
            }
            MessageBox.Show(s2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown1.Value);
            MessageBox.Show(n.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(domainUpDown1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(trackBar1.Value);
            MessageBox.Show(n.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(progressBar1.Value);
            n=n+10;
            if (n > 100)
            {
                n = 0;
            }
            progressBar1.Value = n;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(progressBar1.Value);
            MessageBox.Show(n.ToString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value;
            MessageBox.Show(d.ToString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DateTime d = monthCalendar1.TodayDate;
            MessageBox.Show(d.ToString());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //изменение размера изображения от состояния трек бара
            
            int b = trackBar1.Value;
            if (old_b < b)
            {
                pictureBox1.Size = new System.Drawing.Size(pictureBox1.Size.Width + b * 10, pictureBox1.Size.Height + b * 10);
            }
            else
            {
                pictureBox1.Size = new System.Drawing.Size(pictureBox1.Size.Width - b * 10, pictureBox1.Size.Height - b * 10);
            }
            old_b = b;
        }
    }
    
}

