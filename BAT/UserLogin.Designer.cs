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
            this.TextBox_userIP = new System.Windows.Forms.TextBox();
            this.Label_UserIP = new System.Windows.Forms.Label();
            this.TextBox_userPort = new System.Windows.Forms.TextBox();
            this.label_userPort = new System.Windows.Forms.Label();
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
            // TextBox_userIP
            // 
            this.TextBox_userIP.Location = new System.Drawing.Point(74, 344);
            this.TextBox_userIP.Name = "TextBox_userIP";
            this.TextBox_userIP.Size = new System.Drawing.Size(173, 20);
            this.TextBox_userIP.TabIndex = 0;
            // 
            // Label_UserIP
            // 
            this.Label_UserIP.AutoSize = true;
            this.Label_UserIP.Location = new System.Drawing.Point(12, 344);
            this.Label_UserIP.Name = "Label_UserIP";
            this.Label_UserIP.Size = new System.Drawing.Size(42, 13);
            this.Label_UserIP.TabIndex = 1;
            this.Label_UserIP.Text = "User IP";
            // 
            // TextBox_userPort
            // 
            this.TextBox_userPort.Location = new System.Drawing.Point(74, 370);
            this.TextBox_userPort.Name = "TextBox_userPort";
            this.TextBox_userPort.Size = new System.Drawing.Size(173, 20);
            this.TextBox_userPort.TabIndex = 2;
            // 
            // label_userPort
            // 
            this.label_userPort.AutoSize = true;
            this.label_userPort.Location = new System.Drawing.Point(12, 370);
            this.label_userPort.Name = "label_userPort";
            this.label_userPort.Size = new System.Drawing.Size(48, 13);
            this.label_userPort.TabIndex = 3;
            this.label_userPort.Text = "UserPort";
            // 
            // TextBox_receiverIP
            // 
            this.TextBox_receiverIP.Location = new System.Drawing.Point(376, 344);
            this.TextBox_receiverIP.Name = "TextBox_receiverIP";
            this.TextBox_receiverIP.Size = new System.Drawing.Size(177, 20);
            this.TextBox_receiverIP.TabIndex = 4;
            // 
            // Label_receiverIP
            // 
            this.Label_receiverIP.AutoSize = true;
            this.Label_receiverIP.Location = new System.Drawing.Point(307, 344);
            this.Label_receiverIP.Name = "Label_receiverIP";
            this.Label_receiverIP.Size = new System.Drawing.Size(63, 13);
            this.Label_receiverIP.TabIndex = 5;
            this.Label_receiverIP.Text = "Receiver IP";
            // 
            // textBox_receiverPort
            // 
            this.textBox_receiverPort.Location = new System.Drawing.Point(376, 370);
            this.textBox_receiverPort.Name = "textBox_receiverPort";
            this.textBox_receiverPort.Size = new System.Drawing.Size(177, 20);
            this.textBox_receiverPort.TabIndex = 6;
            // 
            // label_receiverPort
            // 
            this.label_receiverPort.AutoSize = true;
            this.label_receiverPort.Location = new System.Drawing.Point(298, 370);
            this.label_receiverPort.Name = "label_receiverPort";
            this.label_receiverPort.Size = new System.Drawing.Size(72, 13);
            this.label_receiverPort.TabIndex = 7;
            this.label_receiverPort.Text = "Receiver Port";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(615, 415);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(173, 23);
            this.button_connect.TabIndex = 8;
            this.button_connect.Text = "Connect / Login";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(74, 130);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(173, 20);
            this.textBox_userName.TabIndex = 9;
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(15, 136);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(57, 13);
            this.label_userName.TabIndex = 10;
            this.label_userName.Text = "UserName";
            // 
            // textBox_userPassword
            // 
            this.textBox_userPassword.Location = new System.Drawing.Point(74, 157);
            this.textBox_userPassword.Name = "textBox_userPassword";
            this.textBox_userPassword.Size = new System.Drawing.Size(173, 20);
            this.textBox_userPassword.TabIndex = 11;
            // 
            // label_userPassword
            // 
            this.label_userPassword.AutoSize = true;
            this.label_userPassword.Location = new System.Drawing.Point(15, 163);
            this.label_userPassword.Name = "label_userPassword";
            this.label_userPassword.Size = new System.Drawing.Size(56, 13);
            this.label_userPassword.TabIndex = 12;
            this.label_userPassword.Text = "PassWord";
            // 
            // pictureBox_loginImage
            // 
            this.pictureBox_loginImage.Location = new System.Drawing.Point(376, 13);
            this.pictureBox_loginImage.Name = "pictureBox_loginImage";
            this.pictureBox_loginImage.Size = new System.Drawing.Size(412, 295);
            this.pictureBox_loginImage.TabIndex = 13;
            this.pictureBox_loginImage.TabStop = false;
            this.pictureBox_loginImage.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // button_Get_LocalIP
            // 
            this.button_Get_LocalIP.Location = new System.Drawing.Point(615, 366);
            this.button_Get_LocalIP.Name = "button_Get_LocalIP";
            this.button_Get_LocalIP.Size = new System.Drawing.Size(173, 23);
            this.button_Get_LocalIP.TabIndex = 14;
            this.button_Get_LocalIP.Text = "Get Local IP";
            this.button_Get_LocalIP.UseVisualStyleBackColor = true;
            this.button_Get_LocalIP.Click += new System.EventHandler(this.button_Get_LocalIP_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.label_userPort);
            this.Controls.Add(this.TextBox_userPort);
            this.Controls.Add(this.Label_UserIP);
            this.Controls.Add(this.TextBox_userIP);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loginImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_userIP;
        private System.Windows.Forms.Label Label_UserIP;
        private System.Windows.Forms.TextBox TextBox_userPort;
        private System.Windows.Forms.Label label_userPort;
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