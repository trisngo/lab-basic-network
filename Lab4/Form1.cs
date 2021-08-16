using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1_Lab4 b1 = new Bai1_Lab4();
            b1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2_Lab4 b2 = new Bai2_Lab4();
            b2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3_Lab4 b3 = new Bai3_Lab4();
            b3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai4_Lab4 b4 = new Bai4_Lab4();
            b4.ShowDialog();
        }

    }
}
