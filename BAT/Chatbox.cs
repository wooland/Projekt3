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

namespace BAT
{
    public partial class Chatbox : Form
    {
        public Chatbox()
        {
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

        private void AddMessageButton_Click(object sender, EventArgs e)
        {
            ShowChatBox.Items.Add(WriteBox.Text);
        }
    }
}
