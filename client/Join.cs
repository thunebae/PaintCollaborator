using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Whiteboard
{
    public partial class Join : Form
    {
        public Join()
        {
            InitializeComponent();           
        }

        struct MyCode
        {
            public string Code;
            public string Port;
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
        static String FindPort(List<MyCode> List, String a)
        {
            foreach (MyCode c in List_code)
            {
                if (c.Code == a)
                    return c.Port;
            }
            return null;
        }
        private WorkSpace ws = new WorkSpace();

        public delegate void delPassData(string str, string Text, string port);

        private void joinARoom_Click(object sender, EventArgs e)
        {
            String port = FindPort(List_code, code.Text);
            if (port != null)
            {
                delPassData del = new delPassData(ws.funData);
                del(code.Text, nickname.Text, port);
                db.InsertRecords("User", new UserInfo { Admin = false, UserName = nickname.Text });
                ws.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid code!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class UserInfo
        {
            [BsonId]
            public Guid Id { get; set; }
            public string UserName { get; set; }
            public bool Admin { get; set; }
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
            public string U_Id { get; set; }
            public string G_Id { get; set; }
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
        private void Join_Load(object sender, EventArgs e)
        {
            db = new MongoGRUD("WhiteBoardRealtime"); //call Server
            //LoadData
        }
    }
}
