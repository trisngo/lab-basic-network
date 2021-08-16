using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab1
{
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();
        }

        private int checkComboBox(string str)
        {
            if (str == "Decimal")
                return 10;
            else if (str == "Binary")
                return 2;
            else if (str == "Octal")
                return 8;
            else if (str == "Hexadecimal")
                return 16;
            return 0;
        }

        private void convertNum(int fromBase, int toBase)
        {
            try
            {
                //ham sau tham khao tren stackoverflow, su dung Convert.ToString va ToInt64
                string result = Convert.ToString(Convert.ToInt64(textBox1.Text.Trim(), fromBase), toBase);
                textBox2.Text = result;
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng bạn đã chọn !!!");
            }
        }
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            int fromBase = checkComboBox(fromBox.SelectedItem.ToString());
            int toBase = checkComboBox(toBox.SelectedItem.ToString());
            convertNum(fromBase, toBase);
        }
    }
}

