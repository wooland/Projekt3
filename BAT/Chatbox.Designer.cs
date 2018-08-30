namespace BAT
{
    partial class Chatbox
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
            this.ShowChatBox = new System.Windows.Forms.ListBox();
            this.AddMessageButton = new System.Windows.Forms.Button();
            this.WriteBox = new System.Windows.Forms.RichTextBox();
            this.NameLabel = new System.Windows.Forms.ListView();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Listbox_of_Users = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowChatBox
            // 
            this.ShowChatBox.FormattingEnabled = true;
            this.ShowChatBox.Location = new System.Drawing.Point(116, 10);
            this.ShowChatBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowChatBox.Name = "ShowChatBox";
            this.ShowChatBox.Size = new System.Drawing.Size(440, 355);
            this.ShowChatBox.TabIndex = 0;
            this.ShowChatBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // AddMessageButton
            // 
            this.AddMessageButton.Location = new System.Drawing.Point(559, 381);
            this.AddMessageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddMessageButton.Name = "AddMessageButton";
            this.AddMessageButton.Size = new System.Drawing.Size(98, 33);
            this.AddMessageButton.TabIndex = 1;
            this.AddMessageButton.Text = "Add message";
            this.AddMessageButton.UseVisualStyleBackColor = true;
            this.AddMessageButton.Click += new System.EventHandler(this.AddMessageButton_Click);
            // 
            // WriteBox
            // 
            this.WriteBox.Location = new System.Drawing.Point(116, 368);
            this.WriteBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WriteBox.Name = "WriteBox";
            this.WriteBox.Size = new System.Drawing.Size(440, 47);
            this.WriteBox.TabIndex = 4;
            this.WriteBox.Text = "";
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(17, 119);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(86, 30);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.UseCompatibleStateImageBehavior = false;
            this.NameLabel.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(17, 10);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(85, 105);
            this.PictureBox.TabIndex = 6;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Listbox_of_Users
            // 
            this.Listbox_of_Users.FormattingEnabled = true;
            this.Listbox_of_Users.Location = new System.Drawing.Point(17, 155);
            this.Listbox_of_Users.Name = "Listbox_of_Users";
            this.Listbox_of_Users.Size = new System.Drawing.Size(86, 212);
            this.Listbox_of_Users.TabIndex = 7;
            // 
            // Chatbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 424);
            this.Controls.Add(this.Listbox_of_Users);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.WriteBox);
            this.Controls.Add(this.AddMessageButton);
            this.Controls.Add(this.ShowChatBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Chatbox";
            this.Text = "Chatbox";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ShowChatBox;
        private System.Windows.Forms.Button AddMessageButton;
        private System.Windows.Forms.RichTextBox WriteBox;
        private System.Windows.Forms.ListView NameLabel;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ListBox Listbox_of_Users;
    }
}

