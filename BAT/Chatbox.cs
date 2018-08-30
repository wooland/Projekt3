using BAT.Models.Data;
using NetSock;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NetSock.BatNetworking;

namespace BAT
{
    public partial class Chatbox : Form
    {
        public BATContext context { get; set; }
        public DateTime timeStamp;
        public Client client;
        public Chatbox(BATContext context, Client client)
        {
            this.client = client;
            this.context = context;
            
            InitializeComponent();

            ShowChatBox.Text = client.messType;

        }

        public Chatbox(BATContext context)
        {
            this.context = context;
            InitializeComponent();
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
            object temp = JsonConvert.SerializeObject(bob);
            client.SendProtocol(bob);
            ShowChatBox.Items.Add($"{timeStamp.TimeOfDay.Days} {timeStamp.TimeOfDay.Hours}: " + client.messType);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
        }
    }
}
