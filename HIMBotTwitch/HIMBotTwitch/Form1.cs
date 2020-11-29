using HIMBot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib.Client.Models;

namespace HIMBotTwitch
{
    public partial class Form1 : Form
    {
        private delegate void SafeCallDelegate(string text);

        private BotManager _manager;
        private bool _isLogging = false;
        private bool _isConnected = false;

        private List<Announcement> _announcements = new List<Announcement>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _manager = new BotManager();
            _manager.Connected += SetOnlineStatus;
            _manager.LogTxt += SetLogText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_isConnected)
            {
                _manager.Connect(_isLogging);
            } else
            {
                _manager.Disconnect();
            }
        }

        private void btnIsLogging_Click(object sender, EventArgs e)
        {
            if (_isConnected)
            {
                string message = "Please Disconnect before toggling Logs.";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                return;
            }

            if (_isLogging)
            {
                _isLogging = false;
                SetLoggingText("Logging: Off");
                panel2.BackColor = Color.Red;
                SetLoggingBtnText("Enable Logs");
            }
            else
            {
                _isLogging = true;
                SetLoggingText("Logging: On");
                panel2.BackColor = Color.Green;
                SetLoggingBtnText("Disable Logs");
            }
        }

        private void SetOnlineStatus(bool status)
        {
            if (status)
            {
                SetOnlineStatusText("Online");
                panel1.BackColor = Color.Green;
                SetOnlineStatusBtnText("Disconnect");
                _isConnected = true;
    }
            else
            {
                SetOnlineStatusText("Offline");
                panel1.BackColor = Color.Red;
                SetOnlineStatusBtnText("Connect");
                _isConnected = false;
            }
        }

        private void SetOnlineStatusText(string text)
        {
            if (label1.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetOnlineStatusText);
                label1.Invoke(d, new object[] { text });
            }
            else
            {
                label1.Text = text;
            }
        }

        private void SetOnlineStatusBtnText(string text)
        {
            if (btnConnect.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetOnlineStatusBtnText);
                btnConnect.Invoke(d, new object[] { text });
            }
            else
            {
                btnConnect.Text = text;
            }
        }

        private void SetLoggingText(string text)
        {
            if (label2.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetOnlineStatusText);
                label2.Invoke(d, new object[] { text });
            }
            else
            {
                label2.Text = text;
            }
        }

        private void SetLoggingBtnText(string text)
        {
            if (btnIsLogging.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetOnlineStatusBtnText);
                btnIsLogging.Invoke(d, new object[] { text });
            }
            else
            {
                btnIsLogging.Text = text;
            }
        }

        private void SetLogText(string text)
        {
            if (textBox2.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetLogText);
                textBox2.Invoke(d, new object[] { text });
            }
            else
            {
                textBox2.AppendText(text);
            }
        }

        private void ClearChatTxt()
        {
            if (textBox2.InvokeRequired)
            {
                var d = new SafeCallDelegate(SetOnlineStatusBtnText);
            }
            else
            {
                textBox2.Text = "";
            }
        }

        private void btnMsgSent_Click(object sender, EventArgs e)
        {
            if (_isConnected)
            {
                _manager.SendMsg(textBox1.Text);
            } else
            {
                string message = "Please Connect before attempting to send a message.";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                return;
            }
            ClearChatTxt();
        }

        private void btnPanzer_Click(object sender, EventArgs e)
        {
            if (!CheckConnection())
            {
                return;
            }
            _manager.SendMsg("PANZER TANK!");
        }
        
        private bool CheckConnection()
        {
            if (_isConnected)
            {
                return true;
            }
            else
            {
                string message = "Please Connect the bot first.";
                string caption = "Connection Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(label3.Text != null && numericUpDown1.Value >= 0)
            {
                AddAnnouncement(textBox3.Text, (double)numericUpDown1.Value);
            }

        }

        private void AddAnnouncement(string text, double time)
        {
            if (!CheckConnection())
            {
                return;
            }
         
            _announcements.Add(new Announcement(_manager.GetClient(), text, TimeSpan.FromMinutes(time)));
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            string msg = "Please remember to follow!";
            double interval = 45;
            AddAnnouncement(msg, interval);
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            string msg = "If you have any questions make sure to join our discord server!";
            double interval = 60;
            AddAnnouncement(msg, interval);
        }

        private void btnKappa_Click(object sender, EventArgs e)
        {
            if (!CheckConnection())
            {
                return;
            }

            _manager.SendMsg("KappaPride KappaPride KappaPride");
        }
    }
}
