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
    public partial class Lab2_Bai2 : Form
    {
        public Lab2_Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

                textBoxTenFile.Text = ofd.SafeFileName.ToString();
                textBoxUrl.Text = fs.Name.ToString();
                textBoxDong.Text = File.ReadLines(ofd.FileName).Count().ToString();

                long wordCount = 0;
                long charsCount = 0;
                char[] chars = { ' ', '\n', '\r', '\t' }; // o day thiet ke theo kieu dem words cua microsoft word la dem luon '.', ',', '?',...la 1 word.
                
                string[] words = content.Split(chars);

                foreach (string word in words)
                {
                    string w = word.Trim().ToLower();
                    if (w.Length >= 1)//1 tu phai hon 1 ky tu 
                    {
                        wordCount += 1;
                    }
                    charsCount += word.Length;
                }
                textBoxTu.Text = wordCount.ToString();
                textBoxKyTu.Text = charsCount.ToString(); //tinh so ky tu khong co tinh space 
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn file");
            }
        }
    }
}
