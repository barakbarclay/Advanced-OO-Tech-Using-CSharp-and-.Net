namespace ClientClient
{
    partial class Form1
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
            this.Button_OpenConnection = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RichTextBox_Game_Message = new System.Windows.Forms.RichTextBox();
            this.Label_LocalIP = new System.Windows.Forms.Label();
            this.Label_Player = new System.Windows.Forms.Label();
            this.RichTextBox_Connection_Message = new System.Windows.Forms.RichTextBox();
            this.Label_Player_Value = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.TextBox_IP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_OpenConnection
            // 
            this.Button_OpenConnection.Location = new System.Drawing.Point(13, 303);
            this.Button_OpenConnection.Margin = new System.Windows.Forms.Padding(4);
            this.Button_OpenConnection.Name = "Button_OpenConnection";
            this.Button_OpenConnection.Size = new System.Drawing.Size(232, 28);
            this.Button_OpenConnection.TabIndex = 0;
            this.Button_OpenConnection.Text = "Open Connection";
            this.Button_OpenConnection.UseVisualStyleBackColor = true;
            this.Button_OpenConnection.Click += new System.EventHandler(this.Button_OpenConnection_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 67);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_SendPing_Click);
            // 
            // RichTextBox_Game_Message
            // 
            this.RichTextBox_Game_Message.Enabled = false;
            this.RichTextBox_Game_Message.Location = new System.Drawing.Point(253, 35);
            this.RichTextBox_Game_Message.Margin = new System.Windows.Forms.Padding(4);
            this.RichTextBox_Game_Message.Name = "RichTextBox_Game_Message";
            this.RichTextBox_Game_Message.Size = new System.Drawing.Size(226, 67);
            this.RichTextBox_Game_Message.TabIndex = 2;
            this.RichTextBox_Game_Message.Text = "";
            // 
            // Label_LocalIP
            // 
            this.Label_LocalIP.AutoSize = true;
            this.Label_LocalIP.Location = new System.Drawing.Point(16, 262);
            this.Label_LocalIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_LocalIP.Name = "Label_LocalIP";
            this.Label_LocalIP.Size = new System.Drawing.Size(0, 17);
            this.Label_LocalIP.TabIndex = 3;
            // 
            // Label_Player
            // 
            this.Label_Player.AutoSize = true;
            this.Label_Player.Location = new System.Drawing.Point(84, 9);
            this.Label_Player.Name = "Label_Player";
            this.Label_Player.Size = new System.Drawing.Size(48, 17);
            this.Label_Player.TabIndex = 4;
            this.Label_Player.Text = "Player";
            // 
            // RichTextBox_Connection_Message
            // 
            this.RichTextBox_Connection_Message.Enabled = false;
            this.RichTextBox_Connection_Message.Location = new System.Drawing.Point(13, 339);
            this.RichTextBox_Connection_Message.Margin = new System.Windows.Forms.Padding(4);
            this.RichTextBox_Connection_Message.Name = "RichTextBox_Connection_Message";
            this.RichTextBox_Connection_Message.Size = new System.Drawing.Size(232, 67);
            this.RichTextBox_Connection_Message.TabIndex = 5;
            this.RichTextBox_Connection_Message.Text = "";
            // 
            // Label_Player_Value
            // 
            this.Label_Player_Value.AutoSize = true;
            this.Label_Player_Value.Location = new System.Drawing.Point(129, 9);
            this.Label_Player_Value.Name = "Label_Player_Value";
            this.Label_Player_Value.Size = new System.Drawing.Size(66, 17);
            this.Label_Player_Value.TabIndex = 6;
            this.Label_Player_Value.Text = "Unknown";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 35);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 67);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 35);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 67);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 110);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 67);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 110);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 67);
            this.button5.TabIndex = 10;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(173, 110);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 67);
            this.button6.TabIndex = 11;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 185);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 67);
            this.button7.TabIndex = 12;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(93, 185);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 67);
            this.button8.TabIndex = 13;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(173, 185);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 67);
            this.button9.TabIndex = 14;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // TextBox_IP
            // 
            this.TextBox_IP.Location = new System.Drawing.Point(252, 306);
            this.TextBox_IP.Name = "TextBox_IP";
            this.TextBox_IP.Size = new System.Drawing.Size(212, 22);
            this.TextBox_IP.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 427);
            this.Controls.Add(this.TextBox_IP);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Label_Player_Value);
            this.Controls.Add(this.RichTextBox_Connection_Message);
            this.Controls.Add(this.Label_Player);
            this.Controls.Add(this.Label_LocalIP);
            this.Controls.Add(this.RichTextBox_Game_Message);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button_OpenConnection);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_OpenConnection;
        private System.Windows.Forms.RichTextBox RichTextBox_Game_Message;
        private System.Windows.Forms.Label Label_LocalIP;
        private System.Windows.Forms.Label Label_Player;
        private System.Windows.Forms.RichTextBox RichTextBox_Connection_Message;
        private System.Windows.Forms.Label Label_Player_Value;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox TextBox_IP;
    }
}

