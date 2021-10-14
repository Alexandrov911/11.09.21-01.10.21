using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double h = Convert.ToDouble(textBox3.Text);
            double m = Convert.ToDouble(textBox4.Text);
            double p = Convert.ToDouble(textBox5.Text);
            double s = ((a + b) / 2) * h;
            double l = m / (p * s);
            textBox6.Text = l.ToString();
        }
    }
}
