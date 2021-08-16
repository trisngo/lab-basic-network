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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void Lab01_Bai03_Load(object sender, EventArgs e)
        {

        }
        private string soDon(int num)
        {
            string text = "";
            switch (num)
            {
                case 0:
                    text = "Không ";
                    break;
                case 1:
                    text = "Một ";
                    break;
                case 2:
                    text = "Hai ";
                    break;
                case 3:
                    text = "Ba ";
                    break;
                case 4:
                    text = "Bốn ";
                    break;
                case 5:
                    text = "Năm ";
                    break;
                case 6:
                    text = "Sáu ";
                    break;
                case 7:
                    text = "Bảy ";
                    break;
                case 8:
                    text = "Tám ";
                    break;
                case 9:
                    text = "Chín ";
                    break;
            }
            return text;
        }

        private string soHangChuc(int num)
        {
            string text = "";
            if (num <= 19)
            {
                if (num % 10 == 0)
                    text = "Mười ";
                else if (num % 10 == 5)
                    text = "Mười Lăm ";
                else
                    text = "Mười " + soDon(num % 10);
            }
            else
            {
                if (num % 10 == 0)

                    text = soDon((num / 10) % 10) + "Mươi ";
                else if (num % 10 == 1)

                    text = soDon((num / 10) % 10) + "Mươi Mốt ";
                else if (num % 10 == 5)

                    text = soDon((num / 10) % 10) + "Mươi Lăm ";
                else

                    text = soDon((num / 10) % 10) + "Mươi " + soDon(num % 10);
            }
            return text;
        }

        private string soHangTram(int num)
        {
            string text = "";
            if (num % 100 == 0)

                text = soDon((num / 100) % 10) + "Trăm ";
            else if ((num / 10) % 10 == 0)

                text = soDon((num / 100) % 10) + "Trăm Lẻ " + soDon(num % 10);
            else

                text = soDon((num / 100) % 10) + "Trăm " + soHangChuc(num % 100);
            return text;
        }

        private string soHangNgan(int num)
        {
            string text = "";

            if (num >= 1000 && num <= 9999)
                text = soDon((num / 1000) % 10);
            else if (num >= 10000 && num <= 99999)
                text = soHangChuc((num / 1000) % 100);
            else if (num >= 100000 && num <= 999999)
                text = soHangTram((num / 1000) % 1000);

            if (num % 1000 == 0)

                text +=  "Ngàn ";
            else if ((num / 10) % 10 == 0 && ((num/100) % 10 == 0))

                text +=  "Ngàn Không Trăm Lẻ " + soDon(num%10);
            else if ((num / 100) % 10 == 0)

                text += "Ngàn Không Trăm " + soHangChuc(num%100);
            else

                text += "Ngàn " + soHangTram(num%1000);
            return text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            bool check1 = Int32.TryParse(textBox1.Text.Trim(), out num1);
            if (check1 && num1 >= 0 && num1 < 1000000)
            {
                if (num1 >= 0 && num1 <= 9)
                {
                    textBoxResult.Text = soDon(num1);
                }
                else if (num1 >= 10 && num1 <= 99){

                    textBoxResult.Text = soHangChuc(num1);
                }
                else if (num1 >= 100 && num1 <= 999)
                {
                    textBoxResult.Text = soHangTram(num1);
                }
                else if (num1 >= 1000 && num1 <= 999999)
                {
                    textBoxResult.Text = soHangNgan(num1);
                }
            }
            else
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 999,999");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBoxResult.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
