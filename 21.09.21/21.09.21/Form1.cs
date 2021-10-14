using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21._09._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("какой-то текст", "Еще текст", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, 
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           DialogResult r = MessageBox.Show("какой-то текст", "Еще текст", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            MessageBox.Show(r.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("будет сделана пр2?", "Ответ", MessageBoxButtons.YesNo, MessageBoxIcon.Information,
             MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            if (r == DialogResult.Yes)
            {
                MessageBox.Show("отлично!");
            }
            else
            {
                MessageBox.Show("Очень плохо!");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                string s = openFileDialog1.FileName;
                textBox1.Text = System.IO.File.ReadAllText(s);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(s, textBox1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color cl = colorDialog1.Color;
                pictureBox1.BackColor = cl;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font f = fontDialog1.Font;
                label1.Font = f;
            }
        }
    }
}
