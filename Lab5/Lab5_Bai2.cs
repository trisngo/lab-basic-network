using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MailKit.Net.Imap;
using MailKit.Search;
using MailKit;
using MailKit.Security;
using MimeKit;

namespace Lab5_Nhom5
{
    public partial class Lab5_Bai2 : Form
    {
        public Lab5_Bai2()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            using (var client = new ImapClient())
            {
                // Để có thể sử dụng được cần tắt SSL trên MDdaemon
                // Sau khi đăng nhập trên MDaemon chọn Security -> SSL & TLS
                // Và bỏ đánh dấu Enable SSL, STARTTLS, and STLS
                listView1.Clear();
                client.Connect("127.0.0.1", 143, false);

                try
                {
                    client.Authenticate(textBox1.Text, textBox2.Text);
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    
                    listView1.Columns.Add("Email", 400);
                    listView1.Columns.Add("From", 300);
                    listView1.Columns.Add("Thời gian", 300);
                    listView1.View = View.Details;
                    label_Total.Text = inbox.Count.ToString();
                    label_Recent.Text = inbox.Recent.ToString();
                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem name = new ListViewItem(message.Subject);
                        ListViewItem.ListViewSubItem from = new
                        ListViewItem.ListViewSubItem(name, message.From.ToString());
                        name.SubItems.Add(from);
                        ListViewItem.ListViewSubItem date = new
                        ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                        name.SubItems.Add(date);
                        listView1.Items.Add(name);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Vui lòng check lại thông tin tài khoản đã nhập");
                }
                client.Disconnect(true);
            }
        }

        private void checkBoxShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPwd.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
