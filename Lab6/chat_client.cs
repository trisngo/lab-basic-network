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
using System.Net.Sockets;
using System.Threading;
namespace lab6
{
    public partial class chat_client : Form
    {
        public chat_client()
        {
            InitializeComponent();
        }

        //shift toàn hệ thống là 17.
        const int shift_const = 17;

        TcpClient tcpClient;
        IPEndPoint iPEndPoint;
        NetworkStream networkStream;
        Byte[] data;
        bool checkConnect = true;

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() != string.Empty && textBox2.Text.Trim() != string.Empty)
            {
                string strSend = textBox1.Text.Trim() + ": " + textBox2.Text.Trim() + "\n";
                this.data = Encoding.ASCII.GetBytes(ceasarEnc(strSend, shift_const));
                networkStream.Write(data, 0, data.Length);
            }
            
        }
        //hàm khởi tạo các cổng kết nối
        private void Lab3_Bai4_ChatCli_Load(object sender, EventArgs e)
        {
           
            try
            {
                this.tcpClient = new TcpClient();
                this.iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                this.tcpClient.Connect(iPEndPoint);
                this.networkStream = tcpClient.GetStream();
            }
            catch
            {
                MessageBox.Show("Bạn phải bật server trước");
                checkConnect = false;
                this.Close();
            }
            CheckForIllegalCrossThreadCalls = false;

            //tạo luồng lắng nghe server khi vừa kết nối tới
            Thread listen = new Thread(receive);
            listen.IsBackground = true;
            listen.Start();
        }
        //hàm xử lý nhận tin gửi tới
        public void receive()
        {
            try
            {
                
                while (checkConnect)
                {
                    byte[] data = new byte[1024];
                    networkStream.Read(data, 0, data.Length);                 
                    string message = Encoding.ASCII.GetString(data);
                    listView1.Items.Add(new ListViewItem(ceasarDec(message, shift_const)));
                }
            }
            catch
            {
                MessageBox.Show("Đã tắt hoặc đã mất kết nối tới server");
                Close();
            }

        }
        //khi form được tắt thì tự động đóng các kêt nối
        private void Lab3_Bai4_ChatCli_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tcpClient.Connected)
            {
                this.data = Encoding.UTF8.GetBytes("quit\n");
                this.networkStream.Write(data, 0, data.Length);
                this.networkStream.Close();
                this.tcpClient.Close();
            }
        }

        private string ceasarEnc(string data, int shift)
        {
            char[] buffer = data.ToCharArray();
            for(int i = 0; i < buffer.Length; i++)
            {
                char chr = buffer[i];
                if(chr >= 'A' && chr <= 'Z')
                {
                    chr = (char)(chr + shift);
                    if (chr > 'Z')
                        chr = (char)(chr - 26);
                    else if (chr < 'A')
                        chr = (char)(chr + 26);
                }
                else if(chr >= 'a' && chr <= 'z')
                {
                    chr = (char)(chr + shift);
                    if (chr > 'z')
                        chr = (char)(chr - 26);
                    else if (chr < 'a')
                        chr = (char)(chr + 26);
                }
                buffer[i] = chr;
            }
            string cipher = new string(buffer);
            return cipher;
        }

        private string ceasarDec(string data, int shift)
        {
            return ceasarEnc(data, 26 - shift);
        }
    }
}
