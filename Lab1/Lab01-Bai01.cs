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
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int num1, num2;
            bool check1, check2;
            long sum = 0;
            check1 = Int32.TryParse(textBox1.Text.Trim(), out num1);
            check2 = Int32.TryParse(textBox2.Text.Trim(), out num2);
            if (check1 && check2)
            {
                sum = num1 + num2;
                textBox3.Text = sum.ToString();

            }
            else
                MessageBox.Show("Vui lòng nhập số nguyên");
            
        }
    }
}
