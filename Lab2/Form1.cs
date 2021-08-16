using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Lab2_Bai1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Lab2_Bai2().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Lab2_Bai3().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Lab2_Bai4().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Lab2_Bai5().Show();
        }
    }
}
