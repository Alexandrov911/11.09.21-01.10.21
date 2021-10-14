using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void картинка1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }

        private void картинка2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
        }

        private void картинка3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Show();
        }
    }
}
