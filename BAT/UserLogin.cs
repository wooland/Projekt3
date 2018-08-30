using BAT.Models.Data;
using NetSock;
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
using static NetSock.BatNetworking;

namespace BAT
{
    public partial class UserLogin : Form
    {
        string userName;
        string user_PassWord;
        string user_IP;
        int user_Port;
        string reciever_IP;
        int reciever_port;
        public BATContext Context { get; set; }
        public UserLogin(BATContext context)
        {
            InitializeComponent();
            this.Context = context;
            TextBox_userIP.Text = "10.20.38.150";
            textBox_userName.Text = "BatMan";
            textBox_userPassword.Text = "BBBB";
            textBox_receiverPort.Text = "5000";
            TextBox_receiverIP.Text = "10.20.38.150";
            TextBox_userPort.Text = "5000";

            //pictureBox_loginImage.Image= Image.FromFile("../media/technology-c-sharp.png");
        }

        private void Button_connect_Click(object sender, EventArgs e)
        {
            if (TextBox_receiverIP.Text == "" || textBox_receiverPort.Text == "")
            {
                MessageBox.Show("Please enter the proper IP/Port information into the receiver fields");
            }
            if (TextBox_userIP.Text == "" || TextBox_userPort.Text == "")
            {
                MessageBox.Show("Please enter the proper IP/Port information into the User fields");
            }
            if (textBox_userName.Text == "" || textBox_userPassword.Text == "")
            {
                MessageBox.Show("Please enter proper login information");
            }
            else
            {
                userName = textBox_userName.Text;
                user_PassWord = textBox_userPassword.Text;
                user_IP = TextBox_userIP.Text;
                user_Port = Convert.ToInt32(TextBox_userPort.Text);

                reciever_IP = TextBox_receiverIP.Text;
                reciever_port = Convert.ToInt32(textBox_receiverPort.Text);

                 
                
                BatProtocol p = new BatProtocol()
                { Type = "Login", Version = 1, UserName = userName, Password = user_PassWord,
                    RecieverIP = reciever_IP, RecieverPort = reciever_port, UserIP = user_IP, UserPort = user_Port };


                TcpClient tcpclient = new TcpClient(p.RecieverIP, p.RecieverPort);
                Client client = new Client(tcpclient);

                Thread batListener = new Thread(client.Listen);
                batListener.Start();

                Thread batThread = new Thread(client.SendProtocol);
                batThread.Start(p);

                

                var x = new Chatbox(Context, client);
                x.ShowDialog();

                batThread.Join();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}