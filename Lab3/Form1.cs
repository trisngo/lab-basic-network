﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Lab3_Bai1_Dash().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Lab3_Bai2().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Lab3_Bai3_Dash().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Lab3_Bai4_Dash().Show();
        }
    }
}
