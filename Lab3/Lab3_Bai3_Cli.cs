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
namespace lab3
{
    public partial class Lab3_Bai3_Cli : Form
    {
        public Lab3_Bai3_Cli()
        {
            InitializeComponent();
        }
        TcpClient tcpClient;
        IPEndPoint iPEndPoint;
        NetworkStream networkStream;
        Byte[] data;

        private void Lab3_Bai3_Cli_Load(object sender, EventArgs e)
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
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            this.data = Encoding.UTF8.GetBytes("Xin Chào\n");
            networkStream.Write(data, 0, data.Length);
        }

        private void Lab3_Bai3_Cli_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(tcpClient.Connected)
            {
                this.data = Encoding.UTF8.GetBytes("quit\n");
                this.networkStream.Write(data, 0, data.Length);
                this.networkStream.Close();
                this.tcpClient.Close();
            }              
        }
    }
}
