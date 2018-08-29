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
        public BATContext context { get; set; }
        public UserLogin(BATContext context)
        {
            InitializeComponent();
            this.context = context;
            //pictureBox_loginImage.Image= Image.FromFile("../media/technology-c-sharp.png");
        }

        private void button_connect_Click(object sender, EventArgs e)
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

                Client client = new Client();
                BatProtocol p = new BatProtocol()
                { Type = "Login", Version = 1, UserName = userName, Password = user_PassWord,
                    RecieverIP = reciever_IP, RecieverPort = reciever_port, UserIP = user_IP, UserPort = user_Port };

                Object protocol = p;
                Thread batThread = new Thread(client.SendProtocol);
                batThread.Start(protocol);
                batThread.Join();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}