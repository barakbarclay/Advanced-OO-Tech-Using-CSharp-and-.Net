namespace CS3020_Enigma_Machine_HW
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
            this.TextBox_Input = new System.Windows.Forms.TextBox();
            this.TextBox_Output = new System.Windows.Forms.TextBox();
            this.TextBox_Left_Starting_Position = new System.Windows.Forms.TextBox();
            this.TextBox_Middle_Starting_Position = new System.Windows.Forms.TextBox();
            this.TextBox_Right_Starting_Position = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBox_Left1 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Left2 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Left3 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Left4 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Middle1 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Middle2 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Middle3 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Middle4 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Right1 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Right2 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Right3 = new System.Windows.Forms.CheckBox();
            this.CheckBox_Right4 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_Input
            // 
            this.TextBox_Input.Location = new System.Drawing.Point(80, 32);
            this.TextBox_Input.Name = "TextBox_Input";
            this.TextBox_Input.Size = new System.Drawing.Size(357, 22);
            this.TextBox_Input.TabIndex = 0;
            this.TextBox_Input.TextChanged += new System.EventHandler(this.TextBox_Input_TextChanged);
            // 
            // TextBox_Output
            // 
            this.TextBox_Output.Location = new System.Drawing.Point(80, 61);
            this.TextBox_Output.Name = "TextBox_Output";
            this.TextBox_Output.ReadOnly = true;
            this.TextBox_Output.Size = new System.Drawing.Size(357, 22);
            this.TextBox_Output.TabIndex = 1;
            // 
            // TextBox_Left_Starting_Position
            // 
            this.TextBox_Left_Starting_Position.Location = new System.Drawing.Point(298, 131);
            this.TextBox_Left_Starting_Position.Name = "TextBox_Left_Starting_Position";
            this.TextBox_Left_Starting_Position.Size = new System.Drawing.Size(139, 22);
            this.TextBox_Left_Starting_Position.TabIndex = 2;
            this.TextBox_Left_Starting_Position.Text = "0";
            // 
            // TextBox_Middle_Starting_Position
            // 
            this.TextBox_Middle_Starting_Position.Location = new System.Drawing.Point(298, 159);
            this.TextBox_Middle_Starting_Position.Name = "TextBox_Middle_Starting_Position";
            this.TextBox_Middle_Starting_Position.Size = new System.Drawing.Size(139, 22);
            this.TextBox_Middle_Starting_Position.TabIndex = 3;
            this.TextBox_Middle_Starting_Position.Text = "0";
            // 
            // TextBox_Right_Starting_Position
            // 
            this.TextBox_Right_Starting_Position.Location = new System.Drawing.Point(298, 187);
            this.TextBox_Right_Starting_Position.Name = "TextBox_Right_Starting_Position";
            this.TextBox_Right_Starting_Position.Size = new System.Drawing.Size(139, 22);
            this.TextBox_Right_Starting_Position.TabIndex = 4;
            this.TextBox_Right_Starting_Position.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Starting Position(0-9)";
            // 
            // CheckBox_Left1
            // 
            this.CheckBox_Left1.AutoSize = true;
            this.CheckBox_Left1.Checked = true;
            this.CheckBox_Left1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Left1.Location = new System.Drawing.Point(173, 136);
            this.CheckBox_Left1.Name = "CheckBox_Left1";
            this.CheckBox_Left1.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_Left1.TabIndex = 8;
            this.CheckBox_Left1.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Left2
            // 
            this.CheckBox_Left2.AutoSize = true;
            this.CheckBox_Left2.Location = new System.Drawing.Point(197, 135);
            this.CheckBox_Left2.Name = "CheckBox_Left2";
            this.CheckBox_Left2.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_Left2.TabIndex = 9;
            this.CheckBox_Left2.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Left3
            // 
            this.CheckBox_Left3.AutoSize = true;
            this.CheckBox_Left3.Location = new System.Drawing.Point(221, 135);
            this.CheckBox_Left3.Name = "CheckBox_Left3";
            this.CheckBox_Left3.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_Left3.TabIndex = 10;
            this.CheckBox_Left3.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Left4
            // 
            this.CheckBox_Left4.AutoSize = true;
            this.CheckBox_Left4.Location = new System.Drawing.Point(245, 135);
            this.CheckBox_Left4.Name = "CheckBox_Left4";
            this.CheckBox_Left4.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_Left4.TabIndex = 11;
            this.CheckBox_Left4.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Middle1
            // 
            this.CheckBox_Middle1.AutoSize = true;
            this.CheckBox_Middle1.Location = new System.Drawing.Point(173, 163);
            this.CheckBox_Middle1.Name = "CheckBox_Middle1";
            this.CheckBox_Middle1.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_Middle1.TabIndex = 12;
            this.CheckBox_Middle1.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Middle2
            // 
            this.CheckBox_Middle2.AutoSize = true;
            this.CheckBox_Middle2.Checked = true;
            this.CheckBox_Middle2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Middle2.Location = new System.Drawing.Point(197, 163);
            this.CheckBox_Middle2.Name = "CheckBox_Middle2";
            this.CheckBox_Middle2.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_Middle2.TabIndex = 13;
            this.CheckBox_Middle2.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Middle3
            // 
            this.CheckBox_Middle3.AutoSize = true;
            this.CheckBox_Middle3.Location = new System.Drawing.Point(221, 163);
            this.CheckBox_Middle3.Name = "CheckBox_Middle3";
            this.CheckBox_Middle3.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_Middle3.TabIndex = 14;
            this.CheckBox_Middle3.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Middle4
            // 
            this.CheckBox_Middle4.AutoSize = true;
            this.CheckBox_Middle4.Location = new System.Drawing.Point(245, 163);
            this.CheckBox_Middle4.Name = "CheckBox_Middle4";
            this.CheckBox_Middle4.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_Middle4.TabIndex = 15;
            this.CheckBox_Middle4.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Right1
            // 
            this.CheckBox_Right1.AutoSize = true;
            this.CheckBox_Right1.Location = new System.Drawing.Point(173, 191);
            this.CheckBox_Right1.Name = "CheckBox_Right1";
            this.CheckBox_Right1.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_Right1.TabIndex = 16;
            this.CheckBox_Right1.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Right2
            // 
            this.CheckBox_Right2.AutoSize = true;
            this.CheckBox_Right2.Location = new System.Drawing.Point(197, 191);
            this.CheckBox_Right2.Name = "CheckBox_Right2";
            this.CheckBox_Right2.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_Right2.TabIndex = 17;
            this.CheckBox_Right2.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Right3
            // 
            this.CheckBox_Right3.AutoSize = true;
            this.CheckBox_Right3.Checked = true;
            this.CheckBox_Right3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Right3.Location = new System.Drawing.Point(221, 191);
            this.CheckBox_Right3.Name = "CheckBox_Right3";
            this.CheckBox_Right3.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_Right3.TabIndex = 18;
            this.CheckBox_Right3.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Right4
            // 
            this.CheckBox_Right4.AutoSize = true;
            this.CheckBox_Right4.Location = new System.Drawing.Point(245, 191);
            this.CheckBox_Right4.Name = "CheckBox_Right4";
            this.CheckBox_Right4.Size = new System.Drawing.Size(18, 17);
            this.CheckBox_Right4.TabIndex = 19;
            this.CheckBox_Right4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Rotor #";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Left*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Middle*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(122, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Right*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(77, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "*Only one selection per rotor.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckBox_Right4);
            this.Controls.Add(this.CheckBox_Right3);
            this.Controls.Add(this.CheckBox_Right2);
            this.Controls.Add(this.CheckBox_Right1);
            this.Controls.Add(this.CheckBox_Middle4);
            this.Controls.Add(this.CheckBox_Middle3);
            this.Controls.Add(this.CheckBox_Middle2);
            this.Controls.Add(this.CheckBox_Middle1);
            this.Controls.Add(this.CheckBox_Left4);
            this.Controls.Add(this.CheckBox_Left3);
            this.Controls.Add(this.CheckBox_Left2);
            this.Controls.Add(this.CheckBox_Left1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Right_Starting_Position);
            this.Controls.Add(this.TextBox_Middle_Starting_Position);
            this.Controls.Add(this.TextBox_Left_Starting_Position);
            this.Controls.Add(this.TextBox_Output);
            this.Controls.Add(this.TextBox_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Input;
        private System.Windows.Forms.TextBox TextBox_Output;
        private System.Windows.Forms.TextBox TextBox_Left_Starting_Position;
        private System.Windows.Forms.TextBox TextBox_Middle_Starting_Position;
        private System.Windows.Forms.TextBox TextBox_Right_Starting_Position;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckBox_Left1;
        private System.Windows.Forms.CheckBox CheckBox_Left2;
        private System.Windows.Forms.CheckBox CheckBox_Left3;
        private System.Windows.Forms.CheckBox CheckBox_Left4;
        private System.Windows.Forms.CheckBox CheckBox_Middle1;
        private System.Windows.Forms.CheckBox CheckBox_Middle2;
        private System.Windows.Forms.CheckBox CheckBox_Middle3;
        private System.Windows.Forms.CheckBox CheckBox_Middle4;
        private System.Windows.Forms.CheckBox CheckBox_Right1;
        private System.Windows.Forms.CheckBox CheckBox_Right2;
        private System.Windows.Forms.CheckBox CheckBox_Right3;
        private System.Windows.Forms.CheckBox CheckBox_Right4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

