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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void r1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("1.jpg");
        }

        private void r2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("2.jpg");
        }

        private void r3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("3.jpg");
        }
    }
}
