using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Lab2_Bai3 : Form
    {
        public Lab2_Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                textBoxIn.Text = content;
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn file");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxIn.Text))
            {
                MessageBox.Show("Vui lòng ấn nút đọc trước để đọc file");
            }
            else
            {
                string content = textBoxIn.Text.Trim();
                string[] lines = content.Split('\n');
                char[] operators = { '+', '-', '*', '/'};
                
                for(int i=0; i < lines.Length;i++)
                {
                    string[] operands = lines[i].Split(operators);
                    if (operands.Length == 2)
                    {
                        double num1, num2;
                        bool check1, check2;
                        check1 = double.TryParse(operands[0].Trim(), out num1);
                        check2 = double.TryParse(operands[1].Trim(), out num2);
                        if(check1&&check2)
                        {
                            if(lines[i].Contains('+'))
                            {
                                lines[i] += " = " + (num1 + num2);
                            }
                            else if(lines[i].Contains('-'))
                            {
                                lines[i] += " = " + (num1 - num2);
                            }
                            else if(lines[i].Contains('*'))
                            {
                                lines[i] += " = " + (num1 * num2);
                            }
                            else if(lines[i].Contains('/'))
                            {
                                lines[i] += " = " + (num1 / num2);
                            }
                            else
                            {
                                MessageBox.Show("Xuất hiện toán tử không hợp lệ");
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xuất hiện định dạng đầu vào không hợp lệ hoặc các dòng đã có kết quả");
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xuất hiện có số lượng toán hạng không bằng 2");
                        break;
                    }
                }
                textBoxOut.Text = string.Join("\n", lines);
            }
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxOut.Text))
            {
                MessageBox.Show("Không có nội dung để ghi!! Vui lòng ấn nút đọc trước để đọc file và sau đó ấn nút tính để tính kết quả");
            }
            else
            {
                try
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.ShowDialog();
                    FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(textBoxOut.Text);
                    sw.Flush();
                    sw.Close();
                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn nơi lưu file");
                }
            }
        }
    }
}
