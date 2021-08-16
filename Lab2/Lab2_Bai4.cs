using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Lab2
{
    public partial class Lab2_Bai4 : Form
    {
        public Lab2_Bai4()
        {
            InitializeComponent();
        }
       
        private void buttonNhap_Click(object sender, EventArgs e)
        {
            new NhapDuLieuBai4().Show();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            //Mở file input.txt
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName))
            {
                MessageBox.Show("Đường dẫn File input.txt không hợp lệ hoặc không tồn tại");
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            fs.Close();
            sr.Close();

            //chia noi dung trong input thanh các khối khác nhau
            string[] detail = content.Trim().Split(';', '\n');
            
            //khởi tạo excel
            Excel.Application excelApp = new Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);
            Excel._Worksheet workSheet = excelApp.ActiveSheet;
            //Đặt tên cho các cột
            workSheet.Cells[1, "A"] = "MSSV";
            workSheet.Cells[1, "B"] = "Ho Ten";
            workSheet.Cells[1, "C"] = "So Dien Thoai";
            workSheet.Cells[1, "D"] = "DiemToan";
            workSheet.Cells[1, "E"] = "DiemVan";
            workSheet.Cells[1, "F"] = "DiemTB";

            //Làm cho số 0 đứng đầu trong sđt xuất hiện trong excel
            workSheet.Columns["C"].NumberFormat = "@";

            var row = 1;
            for(int i = 0; i < detail.Length; i+=5)//i += 7 vi char cuoi trong cell la \n
            {
                row++;
                workSheet.Cells[row, "A"] = detail[i];
                workSheet.Cells[row, "B"] = detail[i + 1];
                workSheet.Cells[row, "C"] = detail[i + 2];
                
                bool checkDToan, checkDVan;
                checkDToan = float.TryParse(detail[i + 3], out float numDToan);
                checkDVan = float.TryParse(detail[i + 4], out float numDVan);
                if (!checkDToan || !checkDVan)
                {
                    MessageBox.Show("Nội dung điểm toán điểm văn sai định dạng không lưu được");
                    return;
                }
                workSheet.Cells[row, "D"] = numDToan;
                workSheet.Cells[row, "E"] = numDVan;
                workSheet.Cells[row, "F"] = (numDToan + numDVan)/2;
            }

            //Chọn nơi lưu file excel
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            sfd.ShowDialog();
            if (string.IsNullOrEmpty(sfd.FileName))
            {
                MessageBox.Show("Đường dẫn lưu không hợp lệ");
                return;
            }
            excelApp.ActiveWorkbook.SaveCopyAs(sfd.FileName);
            excelApp.ActiveWorkbook.Saved = true;
            excelApp.Quit();
        }

        private void buttonHienThi_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName))
            {
                MessageBox.Show("Đường dẫn File excel không hợp lệ hoặc không tồn tại");
                return;
            }
            try
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(ofd.FileName);
                Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];
                Excel.Range excelRange = excelWorksheet.UsedRange;
                var rowCount = excelRange.RowHeight;
                var colCount = excelRange.ColumnWidth;
                for (var i = 1; i <= rowCount; i++)
                {
                    for (var j = 1; j <= colCount; j++)
                    {
                        //Sau khi kết thúc một hàng thì sẽ xuống hàng trong lần tiếp theo, nhưng không xuống hàng lần đầu tiên
                        if (j == 1 && i != 1)
                            richTextShow.Text += "\r\n";

                        if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                            richTextShow.Text += excelRange.Cells[i, j].Value2.ToString() + "\t";

                    }
                }

                excelWorkbook.Close();
                excelApp.Quit();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString() + "Lưu không thành công.");
            }
        }
    }
}
