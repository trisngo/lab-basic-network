using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Lab4
{
    public partial class Bai2_Lab4 : Form
    {
        public Bai2_Lab4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text.Trim();
            getWeb(url);
        }

        private void getWeb(string gUrl)
        {
            listView1.Items.Clear();
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            try
            {
                WebClient webClient = new WebClient();
                byte[] response = webClient.DownloadData(gUrl);
                richTextBox1.Text = Encoding.UTF8.GetString(response);
                WebHeaderCollection webHeader = webClient.ResponseHeaders;

                string[] headers = webHeader.AllKeys;

                int i = 0;
                foreach (string s in headers)
                {
                    i++;
                    item = new ListViewItem(i.ToString());
                    subItems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(item,s),
                        new ListViewItem.ListViewSubItem(item,webHeader.Get(s))
                    };
                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);
                }


            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới url."); 
            }
        }
    }
}
