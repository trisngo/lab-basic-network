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
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }


        private void xuatManHinh(float[] dsDiem)
        {
            int dem = 0;
            int x = 10, y = 20; 
            Label[] labels = new Label[dsDiem.Length];

            for (int i = 0; i < dsDiem.Length; i++)
            {
                if (dem == 4)
                {
                    x = 10;
                    y += 20;
                    dem = 0;
                }
                labels[i] = new Label();
                // dieu chinh thong so cho cac label se tao
                labels[i].AutoSize = true;
                labels[i].Location = new System.Drawing.Point(x, y);
                labels[i].Size = new System.Drawing.Size(0, 20);
                labels[i].Text = "Môn " + (i+1) + ": " + dsDiem[i] + " đ";
                labels[i].TabIndex = 0;
                x += 150;
                dem++;
                
            }

            // dua labels vừa mới được tạo lên màn hình nằm trong groupbox1
            for (int i = 0; i < dsDiem.Length; i++)
            {
                groupBox1.Controls.Add(labels[i]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            string input = textBox1.Text.Trim();
            string[] dsInput = input.Split(',');
            float[] dsDiem = new float[dsInput.Length];
            float num;
            int i = 0;
            bool flagError = true;//nếu xảy ra lỗi thì không làm gì hết
            foreach(string s in dsInput)
            {
                if (float.TryParse(s, out num))
                {
                    if ((num < 0) || (num > 10))
                    {
                        MessageBox.Show("Nhập Danh Sách Điểm quá mức cho phép, vui lòng nhập lại");
                        flagError = false;
                        break;
                    }
                    dsDiem[i] = num;
                    i++;
                }
                else
                {
                    MessageBox.Show("Nhập Danh Sách Điểm sai cú pháp, vui lòng nhập lại");
                    flagError = false;
                    break;
                }
            }
            if (flagError)
            {
                xuatManHinh(dsDiem);
                //
                float diemMax = 0;
                float diemMin = 10;
                float TongDiem = 0;
                int soMonKoDau = 0;
                foreach(float j in dsDiem)
                {
                    TongDiem += j;
                    if (j > diemMax)
                        diemMax = j;
                    if (j < diemMin)
                        diemMin = j;
                    if (j < 5)
                        soMonKoDau++;
                }

                float DTB = TongDiem / dsDiem.Length;
                //
                labelDiemCao1.Text = "Môn có điểm cao nhất: " + diemMax.ToString();

                labelDiemThap1.Text = "Môn có điểm thấp nhất: " + diemMin.ToString();

                labelDTB.Text = "Điểm trung bình: " + DTB.ToString("F");

                labelMon0Dau.Text = "Số môn không đậu: " + soMonKoDau;

                labelMonDau.Text = "Số môn đậu: " + (dsDiem.Length - soMonKoDau);

                if(DTB >= 8 &&diemMin >= 6.5)
                    labelHocLuc.Text = "Xếp loại học lực: Giỏi";
                else if(DTB >= 6.5 && diemMin >= 5)
                    labelHocLuc.Text = "Xếp loại học lực: Khá";
                else if (DTB >= 5 && diemMin >= 3.5)
                    labelHocLuc.Text = "Xếp loại học lực: TB";
                else if (DTB >= 3.5 && diemMin >= 2)
                    labelHocLuc.Text = "Xếp loại học lực: Yếu";
                else
                    labelHocLuc.Text = "Xếp loại học lực: Kém";
            }
        }
    }
}
