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
using System.Net;
namespace Lab4
{
    public partial class Bai3_Lab4 : Form
    {
        public Bai3_Lab4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text.Trim();
            string fileUrl = textBox2.Text.Trim();

            if (url == null || url.Length == 0)
            {
                MessageBox.Show("Vui long chon trang web");
                return;
            }
            if (fileUrl == null || fileUrl.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn lưu file");
                return;
            }

            getWeb(url, fileUrl);
        }

        private void getWeb(string gUrl,string fileUrl)
        {
            try
            {
                WebClient myClient = new WebClient();
                Stream response = myClient.OpenRead(gUrl);
                StreamReader reader = new StreamReader(response);
                myClient.DownloadFile(gUrl, fileUrl);

                richTextBox1.Text = reader.ReadToEnd();
            }
            catch
            {
                MessageBox.Show("Lỗi :Đường link không hợp lệ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var folderBrowserDialog1 = new FolderBrowserDialog();

                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBox2.Text = folderBrowserDialog1.SelectedPath + "\\web.html";
                }
                
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn nơi lưu file");
            }
        }
    }
}
