using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Whiteboard
{
    public partial class Server : Form
    {
        public Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private string _port = "9090";
        public void tranData(String port)
        {
            _port = port;
            Connect();
        }
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        void Connect()
        {
            clientList = new List<Socket>();
            //IP: server address
            int Port = Int32.Parse(_port);
            IP = new IPEndPoint(IPAddress.Any, Port);
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
                        if(clientList.Count < 4)
                        {
                            clientList.Add(client);
                        }                      
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

        private void Server_Load(object sender, EventArgs e)
        {
            MongoGRUD db = new MongoGRUD("WhiteBoardRealtime"); //call Server          
        }

        public class UserInfo
        {
            [BsonId]
            public Guid Id { get; set; }
            public string UserName { get; set; }
            public bool Admin { get; set; }
            // public DateTime Day { get; set; }
            public string G_Id { get; set; }
        }
        public class Group
        {
            public Guid G_Id { get; set; }
            public string GroupName { get; set; }
            public string M_Id { get; set; }
            public string Code { get; set; }
        }
        public class Code
        {
            public string code { get; set; }
            public string port { get; set; }
        }

        public class MongoGRUD
        {
            private IMongoDatabase db;
            public MongoGRUD(string database)
            {
                var client = new MongoClient("mongodb://127.0.0.1:27017");
                db = client.GetDatabase(database);
            }
            public void InsertRecords<T>(string table, T record)
            {
                var collection = db.GetCollection<T>(table);
                collection.InsertOne(record);
            }
        }
    }
}
