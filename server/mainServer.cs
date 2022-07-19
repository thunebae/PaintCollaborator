using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ServerWhiteboard
{
    public partial class mainServer : Form
    {
        public mainServer()
        {
            CheckForIllegalCrossThreadCalls = false;
            Connect();
            InitializeComponent();
        }

        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        void Connect()
        {
            clientList = new List<Socket>();
            //IP: server address
            IP = new IPEndPoint(IPAddress.Any, 9900);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    //IP: server address
                    IP = new IPEndPoint(IPAddress.Any, 9900);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                }

            });

            Listen.IsBackground = true;
            Listen.Start();
        }
        void Receive(object obj)
        {
            Socket Client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    Client.Receive(data);

                    Image x = (Image)Deserialize(data);
                    //ShowImage(x);

                    foreach (Socket item in clientList)
                    {
                        if (item != null && item != Client)
                        {
                            item.Send(Serialize(x));
                        }
                    }

                }
            }
            catch
            {
                clientList.Remove(Client);
                Client.Close();
            }

        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatterr = new BinaryFormatter();

            formatterr.Serialize(stream, obj);
            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatterr = new BinaryFormatter();

            return formatterr.Deserialize(stream);
        }

    }
}
