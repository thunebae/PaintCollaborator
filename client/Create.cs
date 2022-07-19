using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Whiteboard
{
    public partial class Create : Form
    {
        string code = "";
        public Create()
        {
            InitializeComponent();
        }

        struct MyCode
        {
            public String Code;
            public String Port;
            public MyCode(String Code, String Port)
            {
                this.Code = Code;
                this.Port = Port;
            }
        }
        static List<MyCode> List_code = new List<MyCode>()
        {
            new MyCode("yV3zB7","9900"),
            new MyCode("uKz1vn","9901"),
            new MyCode("keOH2t","9902"),
            new MyCode("APgkfk","9903"),
            new MyCode("0xdXja","9904"),
            new MyCode("5GVokO","9905"),
            new MyCode("5ccokO","9906"),
            new MyCode("axVokA","9907"),
            new MyCode("1234kO","9908"),
            new MyCode("678jhK","9909"),
        };

        private WorkSpace ws = new WorkSpace();
        private Server sr = new Server();

        public delegate void delPassData(string str, string Text, string port);
        public delegate void tranPassData(String port);

        public List<int> listCode = new List<int>();

        private void createARoom_Click(object sender, EventArgs e)
        {            
            Random rd = new Random();
            int index = rd.Next(0, 9);
            while (listCode.Contains(index))
            {
                index = rd.Next(0, 9);
            }

            listCode.Add(index);
            MyCode i = List_code[index];
            code = i.Code;
            tranPassData tran = new tranPassData(sr.tranData);
            tran(i.Port);
            delPassData del = new delPassData(ws.funData);
            del(code, nickname.Text, i.Port);
            db.InsertRecords("User", new UserInfo { Admin = true, UserName = nickname.Text });
            db.InsertRecords("Room", new Code { code = i.Code, port = i.Port });
            this.Close();
            ws.Show();

        }

        public class UserInfo
        {
            [BsonId]
            public Guid Id { get; set; }
            public string UserName { get; set; }
            public bool Admin { get; set; }
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
        public MongoGRUD db;
        private void Create_Load(object sender, EventArgs e)
        {
            db = new MongoGRUD("WhiteBoardRealtime"); //call Server
        }
    }
}
