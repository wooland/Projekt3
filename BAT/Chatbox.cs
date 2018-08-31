using BAT.Models.Data;
using NetSock;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NetSock.BatNetworking;

namespace BAT
{
    public partial class Chatbox : Form
    {
        List<BatUsers> listOfUser;
        public TcpClient client;

        public string messType = "standard responsmessage";

        public BATContext Context { get; set; }
        public string timeStamp;

        public Chatbox()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Thread batListener = new Thread(Listen);
            batListener.Start();
        }

        public Chatbox(BATContext context) : this()
        {
            this.Context = context;
            listOfUser = context.BatUsers.ToList();
            foreach (var item in listOfUser)
            {
                Listbox_of_Users.Items.Add(item.Name);
            }
        }
        public Chatbox(BATContext context, TcpClient client) : this()
        {

            this.Context = context;
            this.client = client;

        }



        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void WriteTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void AddMessageButton_Click(object sender, EventArgs e)
        {
            BatProtocol bob = new BatProtocol {Type = "PM", Message = WriteBox.Text };
            SendProtocol(bob);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
        }



        public void Listen()
        {
            string message = "In case of no inputstring: This is the response";

            try
            {
                while (true)
                {
                    //Här kommer svarsobjektet
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();
                    //dekoda message till objekt
                    BatProtocol deSerializedMessage = JsonConvert.DeserializeObject<BatProtocol>(message);
                    //Console.WriteLine("MessageType: " + deSerializedMessage.Type);

                    this.messType = deSerializedMessage.Type;

                    if (deSerializedMessage.Type == "Ok")
                    {
                        messType = "We're thoroughugh";
                    }
                    else if (deSerializedMessage.Type == "SM")
                    {
                        timeStamp = DateTime.Now.ToShortTimeString();
                        ShowChatBox.Items.Add($"{deSerializedMessage.UserName}:  ({timeStamp})  { deSerializedMessage.Message.ToString()}");

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Send()
        {
            string message = "";

            try
            {
                while (!message.Equals("quit"))
                {
                    NetworkStream n = client.GetStream();

                    message = Console.ReadLine();
                    BinaryWriter w = new BinaryWriter(n);
                    w.Write(message);
                    w.Flush();
                }

                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void SendProtocol(Object input)
        {
            BatProtocol p = (BatProtocol)input;
           

            NetworkStream n = client.GetStream();
            BinaryWriter w = new BinaryWriter(n);

            string protocol = JsonConvert.SerializeObject(p);
            w.Write(protocol);
        }
    }
}

    

