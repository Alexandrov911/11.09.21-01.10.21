﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01._10._21
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString();
            textBox2.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = dateTimePicker1.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Show();
        }
    }
}
