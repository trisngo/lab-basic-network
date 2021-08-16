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
namespace lab3
{
    public partial class Lab3_Bai4_ChatCli : Form
    {
        public Lab3_Bai4_ChatCli()
        {
            InitializeComponent();
        }

        TcpClient tcpClient;
        IPEndPoint iPEndPoint;
        NetworkStream networkStream;
        Byte[] data;


        private void buttonSend_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() != string.Empty && textBox2.Text.Trim() != string.Empty)
            {
                string strSend = textBox1.Text.Trim() + ": " + textBox2.Text.Trim() + "\n";
                this.data = Encoding.UTF8.GetBytes(strSend);
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
                MessageBox.Show("Bạn phải bật listen server trước");
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
                
                while (true)
                {
                    byte[] data = new byte[1024];
                    networkStream.Read(data, 0, data.Length);                 
                    string message = Encoding.UTF8.GetString(data);
                    listView1.Items.Add(new ListViewItem(message));
                }
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới server. Đã tắt hoặc đã mất kết nối");
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
    }
}
