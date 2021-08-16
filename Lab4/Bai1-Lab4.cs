using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai1_Lab4 : Form
    {
        public Bai1_Lab4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text.Trim();
            if (url == null || url.Length == 0)
            {
                MessageBox.Show("Không phát hiện được URL");
                return;
            }
            richTextBox1.Text = getHTML(url);
        }
        
        private string getHTML(string szUrl)
        {
            try
            {
                // tạo url request.
                WebRequest request = WebRequest.Create(szUrl);
                // lấy response.
                WebResponse response = request.GetResponse();
                // lấy stream dữ liệu được gửi về.
                Stream dataStream = response.GetResponseStream();
                // sử dụng stream bằng streamreader.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // đóng kết nối
                response.Close();
                return responseFromServer;
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới url.");
                return null;
            }
        }
    }
}
