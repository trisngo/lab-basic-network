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
    public partial class viewSource : Form
    {
        public viewSource()
        {
            InitializeComponent();
            View();
        }

        private void View()
        {
            Bai4_Lab4 bai4_Lab4 = new Bai4_Lab4();
            string url = "";
            url = bai4_Lab4.presentUrl;

            try
            {
                WebClient webClient = new WebClient();
                byte[] response = webClient.DownloadData(url);
                richTextBox1.Text = Encoding.UTF8.GetString(response);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi" + e.ToString());
            }
        }
        
    }
}
