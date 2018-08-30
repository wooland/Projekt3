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
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowChatBox
            // 
            this.ShowChatBox.FormattingEnabled = true;
            this.ShowChatBox.ItemHeight = 16;
            this.ShowChatBox.Location = new System.Drawing.Point(154, 12);
            this.ShowChatBox.Name = "ShowChatBox";
            this.ShowChatBox.Size = new System.Drawing.Size(586, 436);
            this.ShowChatBox.TabIndex = 0;
            this.ShowChatBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // AddMessageButton
            // 
            this.AddMessageButton.Location = new System.Drawing.Point(745, 469);
            this.AddMessageButton.Name = "AddMessageButton";
            this.AddMessageButton.Size = new System.Drawing.Size(131, 41);
            this.AddMessageButton.TabIndex = 1;
            this.AddMessageButton.Text = "Add message";
            this.AddMessageButton.UseVisualStyleBackColor = true;
            this.AddMessageButton.Click += new System.EventHandler(this.AddMessageButton_Click);
            // 
            // WriteBox
            // 
            this.WriteBox.Location = new System.Drawing.Point(154, 453);
            this.WriteBox.Name = "WriteBox";
            this.WriteBox.Size = new System.Drawing.Size(586, 57);
            this.WriteBox.TabIndex = 4;
            this.WriteBox.Text = "";
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(23, 147);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(113, 36);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.UseCompatibleStateImageBehavior = false;
            this.NameLabel.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(23, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(113, 129);
            this.PictureBox.TabIndex = 6;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Chatbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 522);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.WriteBox);
            this.Controls.Add(this.AddMessageButton);
            this.Controls.Add(this.ShowChatBox);
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
    }
}

