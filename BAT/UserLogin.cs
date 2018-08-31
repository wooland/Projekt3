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
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NetSock.BatNetworking;

namespace BAT
{
    public partial class UserLogin : Form
    {
        string userName = "No username set";
        string user_PassWord = "No Password set";
        string reciever_IP;
        int reciever_port;

        public TcpClient client;

        public string messType = "standard responsmessage";


        public BATContext Context { get; set; }
        public UserLogin(BATContext context)
        {
            InitializeComponent();
            this.Context = context;
            textBox_userName.Text = "BatMan";
            textBox_userPassword.Text = "BBBB";
            textBox_receiverPort.Text = "5000";



            //pictureBox_loginImage.Image= Image.FromFile("../media/technology-c-sharp.png");
        }

        private void Button_connect_Click(object sender, EventArgs e)
        {
            if (TextBox_receiverIP.Text == "" || textBox_receiverPort.Text == "")
            {
                MessageBox.Show("Please enter the proper IP/Port information into the receiver fields");
            }
            if (textBox_userName.Text == "" || textBox_userPassword.Text == "")
            {
                MessageBox.Show("Please enter proper login information");
            }
            else
            {
                userName = textBox_userName.Text;
                user_PassWord = textBox_userPassword.Text;

                reciever_IP = TextBox_receiverIP.Text;
                reciever_port = Convert.ToInt32(textBox_receiverPort.Text);



                BatProtocol p = new BatProtocol()
                {
                    Type = "Login",
                    Version = 1,
                    UserName = userName,
                    Password = user_PassWord,
                    RecieverIP = reciever_IP,
                    RecieverPort = reciever_port,
                };

                client = new TcpClient(p.RecieverIP, p.RecieverPort);

                Thread batListener = new Thread(Listen);
                batListener.Start();

                Thread batThread = new Thread(SendProtocol);
                batThread.Start(p);




                batThread.Join();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button_Get_LocalIP_Click(object sender, EventArgs e)
        {
            TextBox_receiverIP.Text = GetLocalIPAddress();
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No IP");
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
                        
                        var x = new Chatbox(Context, client, userName, deSerializedMessage.Userlist);
                        x.ShowDialog();
                    }
                    else if (deSerializedMessage.Type == "SM")
                    {
                        //messType = deSerializedMessage.Message;

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
            //client = new TcpClient(p.RecieverIP, p.RecieverPort);

            NetworkStream n = client.GetStream();
            BinaryWriter w = new BinaryWriter(n);

            string protocol = JsonConvert.SerializeObject(input);
            w.Write(protocol);
        }
    }
}



