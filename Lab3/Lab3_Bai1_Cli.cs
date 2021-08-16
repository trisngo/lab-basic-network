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
    public partial class Lab3_Bai1_Cli : Form
    {
        public Lab3_Bai1_Cli()
        {
            InitializeComponent();
        }


        private void Lab3_Bai1_Cli_Load(object sender, EventArgs e)
        {
            textBoxIpadd.Text = "127.0.0.1";
            textBoxPort.Text = "8080";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //check ip,port
            bool checkiP, checkPort;
            IPAddress iP;
            checkiP = IPAddress.TryParse(textBoxIpadd.Text.Trim(), out iP);
            checkPort = Int32.TryParse(textBoxPort.Text.Trim(), out int port);
            if(!checkiP || !checkPort)
            {
                MessageBox.Show("Nhap sai ipaddress, port");
                return;
            }
            IPEndPoint iPEndPoint = new IPEndPoint(iP, port);

            UdpClient udpClient = new UdpClient();
            Byte[] sendByte = Encoding.UTF8.GetBytes(richTextMess.Text.Trim());
            udpClient.Send(sendByte, sendByte.Length, iPEndPoint);
        }
    }
}
