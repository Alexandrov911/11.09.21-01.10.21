using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._09._21._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            double a = Convert.ToDouble(textBox1.Text);
            double r = Convert.ToDouble(textBox2.Text);
            r = a / 2;
            double v= a * a * a;
            textBox3.Text = v.ToString();
            double v1 = (4 / 3) * 3.14 * r * r * r;
            textBox4.Text = v1.ToString();
            double m = v - v1;
            textBox5.Text = m.ToString();


        }
    }
}
