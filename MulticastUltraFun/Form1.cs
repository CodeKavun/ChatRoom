using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulticastUltraFun
{
    public partial class Form1 : Form
    {
        private const string IP = "224.5.5.5";

        private int interval = 1000;

        Socket senderSocket;
        Socket receiverSocket;

        Thread receiver;

        delegate void AppendText(string text);

        public Form1()
        {
            InitializeComponent();

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 8000);

            senderSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            senderSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 2);

            receiverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            receiverSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            receiverSocket.Bind(endPoint);

            IPAddress destination = IPAddress.Parse("224.5.5.5");
            receiverSocket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(destination, IPAddress.Any));

            receiver = new Thread(new ThreadStart(DoClientStuff)) { IsBackground = true };
            receiver.Start();
        }

        private void DoClientStuff()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);

                    int receivedLength = receiverSocket.ReceiveFrom(buffer, ref remoteEndPoint);
                    string message = Encoding.Unicode.GetString(buffer, 0, receivedLength);

                    Invoke((MethodInvoker)delegate { chatViewer.AppendText(message + Environment.NewLine); });
                }
            }
            catch (SocketException sockEx)
            {
                MessageBox.Show("Something wrong with network: " + sockEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some unexpected error: " + ex.Message);
            }
        }

        private void SendMessage(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IP), 8000);
            senderSocket.SendTo(bytes, endPoint);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string message = userField.Text + ": " + messageField.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                SendMessage(message);
                messageField.Clear();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            receiverSocket?.Close();
            senderSocket?.Close();
            receiver?.Join();
        }
    }
}
