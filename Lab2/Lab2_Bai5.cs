using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2_Bai5 : Form
    {
        public Lab2_Bai5()
        {
            InitializeComponent();
        }
        public string explorerPath = "D:\\UIT\\";
        private void Lab2_Bai5_Load(object sender, EventArgs e)
        {
            showDir_File(explorerPath);
        }

        void showDir_File(string path)
        {
            listView1.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(path);

            ListViewItem.ListViewSubItem[] itemsCon;
            ListViewItem item = null;

            //Đoạn code sau có tham khảo tại nguồn:https://docs.microsoft.com/
            //Lấy thông tin của từng thư mục

            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                item = new ListViewItem(dir.Name);
                itemsCon = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "Directory"),
                    //thu muc se khong hien kich thuoc va duoi file
                    new ListViewItem.ListViewSubItem(item, String.Empty),
                    new ListViewItem.ListViewSubItem(item, String.Empty),
                    new ListViewItem.ListViewSubItem(item, dir.CreationTime.ToString())
                };
                item.SubItems.AddRange(itemsCon);
                listView1.Items.Add(item);
            }
            //Lấy thông tin của từng file
            foreach (FileInfo fileAddr in di.GetFiles())
            {
                item = new ListViewItem(fileAddr.Name);
                itemsCon = new ListViewItem.ListViewSubItem[]
                {
                    new ListViewItem.ListViewSubItem(item, "File"),
                    new ListViewItem.ListViewSubItem(item, fileAddr.Length.ToString()),
                    new ListViewItem.ListViewSubItem(item, fileAddr.Extension.ToString()),
                    new ListViewItem.ListViewSubItem(item, fileAddr.CreationTime.ToString())
                };

                item.SubItems.AddRange(itemsCon);
                listView1.Items.Add(item);
            }

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                //nếu là thư mục mới được chọn để duyệt
                if(listView1.SelectedItems[0].SubItems[1].Text == "Directory")
                {
                    explorerPath += listView1.SelectedItems[0].Text + "\\";
                    showDir_File(explorerPath);
                }
            }
        }
    }
}
