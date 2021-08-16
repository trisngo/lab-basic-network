using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bai1_Click(object sender, EventArgs e)
        {
            new Lab01_Bai01().Show();
        }

        private void bai2_Click(object sender, EventArgs e)
        {
            new Lab01_Bai02().Show();
        }

        private void bai3_Click(object sender, EventArgs e)
        {
            new Lab01_Bai03().Show();
        }

        private void bai4_Click(object sender, EventArgs e)
        {
            new Lab01_Bai04().Show();
        }

        private void bai5_Click(object sender, EventArgs e)
        {
            new Lab01_Bai05().Show();
        }
    }
}
