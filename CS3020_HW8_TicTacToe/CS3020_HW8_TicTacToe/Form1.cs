using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Reflection;

/// <summary>
/// First real line in Button_OpenConnection_Click is where you put their IP Address.
/// I recommend using a textbox for input and just have TextBox.Text there instead.
/// 
/// Both clients need to click Open Connection to start the connection. Afterwards pings work as expected.
/// </summary>
namespace ClientClient
{
    public partial class Form1 : Form
    {
        TcpClient connection;

        public Form1()
        {
            InitializeComponent();
            Label_LocalIP.Text = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
        }

        private void AddToConnectionMessageBox(string s)
        {
            //Must invoke as delegate due to cross thread work
            this.Invoke(new MethodInvoker(delegate
            {
                RichTextBox_Connection_Message.AppendText(s + "\n");
                RichTextBox_Connection_Message.ScrollToCaret();
            }));
        }

        private async void Button_OpenConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_IP.Text == "")
                {
                    connection = new TcpClient(Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString(), 5555);
                }
                else
                {
                    connection = new TcpClient(TextBox_IP.Text, 5555);
                }
            }
            catch
            {
                Label_Player_Value.Text = "X";
                AddToConnectionMessageBox("No listener found, opening listener.");

                if (TextBox_IP.Text == "")
                {
                    TcpListener listener = new TcpListener(Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork), 5555);
                    listener.Start();
                    connection = await listener.AcceptTcpClientAsync();
                    RichTextBox_Game_Message.Text = "Your Turn";
                    await Task.Factory.StartNew(() => ListenForPacket(connection));
                    listener.Stop();
                }
                else
                {
                    IPAddress textBoxIP = IPAddress.Parse(TextBox_IP.Text);
                    TcpListener listener = new TcpListener(textBoxIP, 5555);
                    listener.Start();
                    connection = await listener.AcceptTcpClientAsync();
                    await Task.Factory.StartNew(() => ListenForPacket(connection));
                    listener.Stop();
                }
                return;
            }
            AddToConnectionMessageBox("Listener found, connection successful.");
            RichTextBox_Game_Message.Text = "Opponent's Turn";
            Label_Player_Value.Text = "O";
            await Task.Factory.StartNew(() => ListenForPacket(connection));
        }

        private void MainButtonFunction(Button button)
        {
            if (button.Text == "" && RichTextBox_Game_Message.Text == "Your Turn")
            {
                SendMessage(connection, button.Name);
                button.Text = Label_Player_Value.Text;
                RichTextBox_Game_Message.Text = "Opponent's Turn";
                CheckForWinner();
            }
        }

        private void CheckForWinner()
        {
            List<Button> btnList = Enumerable.Range(1, 9).Select(i => (Button)this.Controls["button" + i.ToString()]).ToList();

            for (int i = 0; i < 3; i++)
            {
                //Check Row
                if (btnList[(i * 3)].Text != "" && btnList[(i * 3)].Text.Equals(btnList[(i * 3) + 1].Text) && btnList[(i * 3) + 1].Text.Equals(btnList[(i * 3) + 2].Text))
                {
                    RichTextBox_Game_Message.Text = "You Won";
                    SendMessage(connection, "You Lost");
                }
                //Check Col
                if (btnList[i].Text != "" && btnList[i].Text.Equals(btnList[i + 3].Text) && btnList[i + 3].Text.Equals(btnList[i + 6].Text))
                {
                    RichTextBox_Game_Message.Text = "You Won";
                    SendMessage(connection, "You Lost");
                }
            }
            //Check diag 1
            if (btnList[1].Text != "" && btnList[1].Text.Equals(btnList[4].Text) && btnList[4].Text.Equals(btnList[8].Text))
            {
                RichTextBox_Game_Message.Text = "You Won";
                SendMessage(connection, "You Lost");
            }
            //Check diag 2
            if (btnList[2].Text != "" && btnList[2].Text.Equals(btnList[4].Text) && btnList[4].Text.Equals(btnList[6].Text))
            {
                RichTextBox_Game_Message.Text = "You Won";
                SendMessage(connection, "You Lost");
            }
            //Check for draw
            for (int i = 0; i < 9; i++)
            {
                if (btnList[i].Text == "")
                {
                    break;
                }
                if (i == 8)
                {
                    RichTextBox_Game_Message.Text = "Draw";
                    SendMessage(connection, "Draw");
                }
            }
        }

        private void ListenForPacket(TcpClient singleConnection)
        {
            NetworkStream stream = singleConnection.GetStream();
            while (true)
            {
                byte[] bytesToRead = new byte[singleConnection.ReceiveBufferSize];
                int bytesRead = stream.Read(bytesToRead, 0, singleConnection.ReceiveBufferSize);
                string result = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
                if (result != "" && result != "You Lost" && result != "Draw")
                {
                    RichTextBox_Game_Message.Text = "Your Turn";
                    if (Label_Player_Value.Text == "X")
                        this.Controls[result].Text = "O";
                    else
                        this.Controls[result].Text = "X";
                }
                else if (result == "You Lost" || result == "Draw")
                {
                    RichTextBox_Game_Message.Text = result;
                }
            }
        }

        private void SendMessage(TcpClient singleConnection, string s)
        {
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(s);
            singleConnection.GetStream().Write(bytesToSend, 0, bytesToSend.Length);
        }











        private void Button_SendPing_Click(object sender, EventArgs e)
        {
            MainButtonFunction(button1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MainButtonFunction(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainButtonFunction(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainButtonFunction(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainButtonFunction(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainButtonFunction(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainButtonFunction(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MainButtonFunction(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MainButtonFunction(button9);
        }









        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label_Player_Value_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
