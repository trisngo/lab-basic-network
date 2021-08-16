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
    public partial class Lab3_Bai3_Ser : Form
    {
        public Lab3_Bai3_Ser()
        {
            InitializeComponent();
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.IsBackground = true;
            serverThread.Start();
            buttonListen.Enabled = false;
        }

        private void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];

            Socket clientSocket;
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iPEndSever = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listView1.Items.Add(new ListViewItem("Server running on 127.0.0.1:8080"));

            listenerSocket.Bind(iPEndSever);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();
            listView1.Items.Add(new ListViewItem("Found a new client connected from " + ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString() + ":" + ((IPEndPoint)clientSocket.RemoteEndPoint).Port.ToString()));
            while (clientSocket.Connected)
            {
                string text = "";
                byte[] buffer = new byte[1024];
                int index = 0;
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.UTF8.GetString(recv);
                    Buffer.BlockCopy(recv, 0, buffer, index, bytesReceived);
                    index++;
                } while (text[text.Length - 1] != '\n');
                if (text == "quit\n")
                {
                    listView1.Items.Add(new ListViewItem("Client disconnected."));
                    break;
                }
                text = Encoding.UTF8.GetString(buffer);
                listView1.Items.Add(new ListViewItem(text));
            }
            clientSocket.Close();
            listenerSocket.Close();
            buttonListen.Enabled = true;
        }
    }
}
