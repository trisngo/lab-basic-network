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
    public partial class Lab3_Bai1_Ser : Form
    {
        public Lab3_Bai1_Ser()
        {
            InitializeComponent();
        }
        
        private void buttonListen_Click(object sender, EventArgs e)
        {
            //CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.IsBackground = true;

            thdUDPServer.Start();
            buttonListen.Enabled = false;
        }

        private void serverThread()
        {
            bool checkPort;
            checkPort = Int32.TryParse(textBox1.Text.Trim(), out int port);
            if (!checkPort)
            {
                MessageBox.Show("Nhap sai port");
                return;
            }

            UdpClient udpClient = new UdpClient(port);
            while (true)
            {
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveByte = udpClient.Receive(ref iPEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveByte);
                string messData = iPEndPoint.Address.ToString() + ":" + returnData.ToString();
                infoMessage(messData);
            }
        }

        void infoMessage(string mess)
        {
            ListViewItem item = new ListViewItem(mess, 0);
            listViewMess.Invoke(new MethodInvoker(delegate ()
            {
                listViewMess.Items.Add(item);
            }));
        }

        private void Lab3_Bai1_Ser_Load(object sender, EventArgs e)
        {
            //port mặc định là 8080
            textBox1.Text = "8080";
        }
    }
}
