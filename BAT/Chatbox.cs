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

        public TcpClient client;

        public string messType = "standard responsmessage";

        public BATContext context { get; set; }
        public string timeStamp = DateTime.Now.ToShortTimeString();

        public Chatbox()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Thread batListener = new Thread(Listen);
            batListener.Start();
        }

        public Chatbox(BATContext context) : this()
        {
            
            this.context = context;
            
            

            //ShowChatBox.Text = client.messType;

        }
        public Chatbox(BATContext context, TcpClient client) : this()
        {

            this.context = context;
            this.client = client;

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void WriteTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //NameLabel.Items.Add(UserName.Text);
        }

        public void AddMessageButton_Click(object sender, EventArgs e)
        {
            BatProtocol bob = new BatProtocol {Type = "PM", Message = WriteBox.Text, RecieverIP = "10.20.38.150", RecieverPort = 5000 };
            
            SendProtocol(bob);

            

            //ShowChatBox.Items.Add($"{timeStamp}: " + client.messType);
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
                       
                        ShowChatBox.Items.Add($"{timeStamp}: " + deSerializedMessage.Message.ToString());

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

            string protocol = JsonConvert.SerializeObject(input);
            w.Write(protocol);
        }
    }
}

    

