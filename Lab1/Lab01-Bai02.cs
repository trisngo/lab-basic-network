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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private double findMax(double num1, double num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }

        private double findMin(double num1, double num2)
        {
            if (num1 < num2)
                return num1;
            else
                return num2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            bool check1, check2, check3;
            check1 = double.TryParse(textBox1.Text.Trim(), out num1);
            check2 = double.TryParse(textBox2.Text.Trim(), out num2);
            check3 = double.TryParse(textBox3.Text.Trim(), out num3);
            if (check1 && check2 && check3)
            {
                textMax.Text = findMax(findMax(num1, num2), num3).ToString();
                textMin.Text = findMin(findMin(num1, num2), num3).ToString();
            }
            else
                MessageBox.Show("Vui lòng nhập số");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textMax.Clear();
            textMin.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
