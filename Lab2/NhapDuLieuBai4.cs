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
using System.Text.RegularExpressions;

namespace Lab2
{
    public partial class NhapDuLieuBai4 : Form
    {
        public NhapDuLieuBai4()
        {
            InitializeComponent();
        }

        private void buttonNhap_Click(object sender, EventArgs e)
        {
            bool checkMSSV, checkName, checkPhone, checkDToan, checkDVan;
            
            if (String.IsNullOrEmpty(textMSSV.Text.Trim())) 
                checkMSSV = false;
            else
            {
                Regex rgx = new Regex("[^A-Za-z0-9]");
                checkMSSV = rgx.IsMatch(textMSSV.Text.Trim());
                checkMSSV = !checkMSSV;
            }

            string[] Name = textHoTen.Text.Trim().Split(' ');
            checkName = true;
            if (String.IsNullOrEmpty(textHoTen.Text.Trim())) 
                checkName = false;
            else
            {
                foreach (string subNames in Name)
                {
                    if (!Char.IsUpper(subNames[0]))
                    {
                        checkName = false;
                        break;
                    }
                    foreach (char c in subNames)
                    {
                        if (!Char.IsLetter(c))
                        {
                            checkName = false;
                            break;
                        }
                    }
                }
            }

            checkPhone = Int32.TryParse(textPhone.Text.Trim(), out int numPhone);

            checkDToan = float.TryParse(textDiemToan.Text.Trim(), out float numDToan);
            checkDVan = float.TryParse(textDiemVan.Text.Trim(), out float numDVan);

            if(!checkName)
            {
                MessageBox.Show("Định dạng ô Họ Tên không hợp lệ! Vui lòng nhập lại.");
            }
            else if(!checkMSSV)
            {
                MessageBox.Show("Định dạng ô MSSV không hợp lệ! Vui lòng nhập lại.");
            }
            else if(!checkPhone || (textPhone.Text.Trim().ToString().Length != 10))//sử dụng textPhone vì numPhone khi chuyển đổi đã làm mất số 0 đứng đầu.
            {
                MessageBox.Show("Định dạng ô Số ĐT không hợp lệ! Vui lòng nhập lại.");
            }
            else if(!checkDToan || numDToan < 0 || numDToan > 10)
            {
                MessageBox.Show("Định dạng ô Điểm toán không hợp lệ! Vui lòng nhập lại.");
            }
            else if(!checkDVan || numDVan < 0 || numDVan > 10)
            {
                MessageBox.Show("Định dạng ô Điểm văn không hợp lệ! Vui lòng nhập lại.");
            }
            else
            {
                try
                {
                    string strOut = textMSSV.Text.Trim() + ";" + textHoTen.Text.Trim() + ";" + textPhone.Text.Trim() + ";" + textDiemToan.Text.Trim() + ";" + textDiemVan.Text.Trim();
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.ShowDialog();
                    FileStream fs = new FileStream(sfd.FileName, FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(strOut + "\n");
                    sw.Flush();
                    sw.Close();
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ lưu.");
                }
            }
        }
    }
}
