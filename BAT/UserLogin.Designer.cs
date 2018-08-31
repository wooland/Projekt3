namespace BAT
{
    partial class UserLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_receiverIP = new System.Windows.Forms.TextBox();
            this.Label_receiverIP = new System.Windows.Forms.Label();
            this.textBox_receiverPort = new System.Windows.Forms.TextBox();
            this.label_receiverPort = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.label_userName = new System.Windows.Forms.Label();
            this.textBox_userPassword = new System.Windows.Forms.TextBox();
            this.label_userPassword = new System.Windows.Forms.Label();
            this.pictureBox_loginImage = new System.Windows.Forms.PictureBox();
            this.button_Get_LocalIP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_receiverIP
            // 
            this.TextBox_receiverIP.Location = new System.Drawing.Point(114, 249);
            this.TextBox_receiverIP.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_receiverIP.Name = "TextBox_receiverIP";
            this.TextBox_receiverIP.Size = new System.Drawing.Size(235, 22);
            this.TextBox_receiverIP.TabIndex = 4;
            // 
            // Label_receiverIP
            // 
            this.Label_receiverIP.AutoSize = true;
            this.Label_receiverIP.Location = new System.Drawing.Point(15, 254);
            this.Label_receiverIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_receiverIP.Name = "Label_receiverIP";
            this.Label_receiverIP.Size = new System.Drawing.Size(80, 17);
            this.Label_receiverIP.TabIndex = 5;
            this.Label_receiverIP.Text = "Receiver IP";
            // 
            // textBox_receiverPort
            // 
            this.textBox_receiverPort.Location = new System.Drawing.Point(114, 279);
            this.textBox_receiverPort.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_receiverPort.Name = "textBox_receiverPort";
            this.textBox_receiverPort.Size = new System.Drawing.Size(235, 22);
            this.textBox_receiverPort.TabIndex = 6;
            // 
            // label_receiverPort
            // 
            this.label_receiverPort.AutoSize = true;
            this.label_receiverPort.Location = new System.Drawing.Point(1, 284);
            this.label_receiverPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_receiverPort.Name = "label_receiverPort";
            this.label_receiverPort.Size = new System.Drawing.Size(94, 17);
            this.label_receiverPort.TabIndex = 7;
            this.label_receiverPort.Text = "Receiver Port";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(114, 368);
            this.button_connect.Margin = new System.Windows.Forms.Padding(4);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(235, 28);
            this.button_connect.TabIndex = 8;
            this.button_connect.Text = "Connect / Login";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(114, 109);
            this.textBox_userName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(229, 22);
            this.textBox_userName.TabIndex = 9;
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(20, 114);
            this.label_userName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(75, 17);
            this.label_userName.TabIndex = 10;
            this.label_userName.Text = "UserName";
            // 
            // textBox_userPassword
            // 
            this.textBox_userPassword.Location = new System.Drawing.Point(114, 139);
            this.textBox_userPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_userPassword.Name = "textBox_userPassword";
            this.textBox_userPassword.Size = new System.Drawing.Size(229, 22);
            this.textBox_userPassword.TabIndex = 11;
            // 
            // label_userPassword
            // 
            this.label_userPassword.AutoSize = true;
            this.label_userPassword.Location = new System.Drawing.Point(20, 144);
            this.label_userPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_userPassword.Name = "label_userPassword";
            this.label_userPassword.Size = new System.Drawing.Size(73, 17);
            this.label_userPassword.TabIndex = 12;
            this.label_userPassword.Text = "PassWord";
            // 
            // pictureBox_loginImage
            // 
            this.pictureBox_loginImage.ImageLocation = "C:\\Projects\\BAT\\BAT\\Resources\\batpicture.png";
            this.pictureBox_loginImage.Location = new System.Drawing.Point(426, 33);
            this.pictureBox_loginImage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_loginImage.Name = "pictureBox_loginImage";
            this.pictureBox_loginImage.Size = new System.Drawing.Size(517, 363);
            this.pictureBox_loginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_loginImage.TabIndex = 13;
            this.pictureBox_loginImage.TabStop = false;
            this.pictureBox_loginImage.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // button_Get_LocalIP
            // 
            this.button_Get_LocalIP.Location = new System.Drawing.Point(114, 325);
            this.button_Get_LocalIP.Margin = new System.Windows.Forms.Padding(4);
            this.button_Get_LocalIP.Name = "button_Get_LocalIP";
            this.button_Get_LocalIP.Size = new System.Drawing.Size(235, 28);
            this.button_Get_LocalIP.TabIndex = 14;
            this.button_Get_LocalIP.Text = "Get Local IP";
            this.button_Get_LocalIP.UseVisualStyleBackColor = true;
            this.button_Get_LocalIP.Click += new System.EventHandler(this.Button_Get_LocalIP_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 459);
            this.Controls.Add(this.button_Get_LocalIP);
            this.Controls.Add(this.pictureBox_loginImage);
            this.Controls.Add(this.label_userPassword);
            this.Controls.Add(this.textBox_userPassword);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label_receiverPort);
            this.Controls.Add(this.textBox_receiverPort);
            this.Controls.Add(this.Label_receiverIP);
            this.Controls.Add(this.TextBox_receiverIP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loginImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBox_receiverIP;
        private System.Windows.Forms.Label Label_receiverIP;
        private System.Windows.Forms.TextBox textBox_receiverPort;
        private System.Windows.Forms.Label label_receiverPort;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.TextBox textBox_userPassword;
        private System.Windows.Forms.Label label_userPassword;
        private System.Windows.Forms.PictureBox pictureBox_loginImage;
        private System.Windows.Forms.Button button_Get_LocalIP;
    }
}