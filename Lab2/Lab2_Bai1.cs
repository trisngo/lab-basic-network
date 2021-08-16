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
    public partial class Lab2_Bai1 : Form
    {
        public Lab2_Bai1()
        {
            InitializeComponent();
        }

        private void buttonReadF_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn file");
            }
        }

        private void buttonWriteF_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.ShowDialog();
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(richTextBox1.Text.ToUpper());
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
