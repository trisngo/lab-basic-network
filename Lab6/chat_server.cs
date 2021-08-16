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
    public partial class chat_server : Form
    {
        private static List<Socket> clientSockets = new List<Socket>();
        
        public chat_server()
        {
            InitializeComponent();
            startListen();
        }

        //shift toàn hệ thống là 17.
        const int shift = 17;
        private void startListen()
        {
            //tao luon cho viec lang nghe va ghi thong tin len listview
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.IsBackground = true;
            serverThread.Start();
        }        
      
        private void StartUnsafeThread()
        {
           //connect voi ipend
            Socket clientSocket;
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iPEndSever = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listView1.Items.Add(new ListViewItem("Server running on 127.0.0.1:8080"));

            listenerSocket.Bind(iPEndSever);
            listenerSocket.Listen(-1);

            //sau đó tạo luồn cho việc lắng nghe từ nhiều client tới
            clientSocket = default(Socket);
            while(true)
            {
                clientSocket = listenerSocket.Accept();
                clientSockets.Add(clientSocket);
                CheckForIllegalCrossThreadCalls = false;
                Thread clientThrd = new Thread(new ThreadStart(() => this.clientProcess(clientSocket)));
                clientThrd.IsBackground = true;
                clientThrd.Start();
            }

        }
        //xử lý các gói tin tới thành string và gửi lại các tin nhắn cho tất cả các client
        public void clientProcess(Socket clientSocket)
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];
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
                    string disconnectMess = "Client from " + ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString() + ":" + ((IPEndPoint)clientSocket.RemoteEndPoint).Port.ToString() + " disconnected";
                    listView1.Items.Add(new ListViewItem(disconnectMess));
                    sendAllClients(disconnectMess);
                    //gỡ bỏ socket được thoát khỏi danh sách
                    clientSockets.Remove(clientSocket);
                    return;
                }
                text = Encoding.ASCII.GetString(buffer);
                listView1.Items.Add(new ListViewItem(((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString() + ":" + ((IPEndPoint)clientSocket.RemoteEndPoint).Port.ToString() + ": " + text));
                sendAllClients(text);

            }
            clientSocket.Close();
        }
        //gửi tin nhắn lại cho tát cả các client
        public void sendAllClients(string text)
        {
            byte[] data = Encoding.ASCII.GetBytes(text);
            foreach (Socket subclient in clientSockets)
            {
                if (subclient != null)
                {
                    subclient.Send(data);
                }

            }
        }
    }
}
