using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAT
{
    public partial class UserLogin : Form
    {
        string userName;
        string user_PassWord;
        string user_IP;
        string user_Port;
        string reciever_IP;
        string reciever_port;

        public UserLogin()
        {
            InitializeComponent();
            //pictureBox_loginImage.Image= Image.FromFile("../media/technology-c-sharp.png");
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            if (TextBox_receiverIP.Text=="" || textBox_receiverPort.Text == "")
            {
                MessageBox.Show("Please enter the proper IP/Port information into the receiver fields");
            }
            if (TextBox_userIP.Text == "" || TextBox_userPort.Text=="")
            {
                MessageBox.Show("Please enter the proper IP/Port information into the User fields");
            }
            if (textBox_userName.Text == "" || textBox_userPassword.Text=="")
            {
                MessageBox.Show("Please enter proper login information");
            }
            else
            {
                userName = textBox_userName.Text;
                user_PassWord = textBox_userPassword.Text;
                user_IP = TextBox_userIP.Text;
                user_Port = TextBox_userPort.Text;

                reciever_IP = TextBox_receiverIP.Text;
                reciever_port = textBox_receiverPort.Text;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
