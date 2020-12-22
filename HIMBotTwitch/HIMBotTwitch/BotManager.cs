using System;
using TwitchLib.Client;
using TwitchLib.Client.Models;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;

namespace HIMBotTwitch
{
    class BotManager
    {
        private readonly ConnectionCredentials creds = new ConnectionCredentials(TwitchInfo.ChannelName, TwitchInfo.BotToken);
        private TwitchClient client;

        public Action<bool> Connected;
        public Action<string> LogTxt;

        private string[] _bannedWords = new string[4] { "bigfollow", "big follows", "retard", "js is best" };

        internal void Connect(bool isLogging)
        {
            LogTxt("[Bot]: Initializing...");
            client = new TwitchClient();

            // TwitchLib Client
            client.Initialize(creds, TwitchInfo.ChannelName);
            client.OnConnectionError += Client_OnConnectionError;
            client.OnConnected += Client_OnConnected;
            client.OnChatCommandReceived += Client_OnChatCommandRecieved;
            client.OnMessageReceived += Client_OnMessageReceived;

            client.Connect();
        }


        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            for (int i = 0; i < _bannedWords.Length; i++)
            {
                if (e.ChatMessage.Message.ToLower().Contains(_bannedWords[i]))
                {
                    client.BanUser(TwitchInfo.ChannelName, e.ChatMessage.Username);
                }
            }

            if (LogTxt != null)
            {
                LogTxt($"[{e.ChatMessage.Username}]: {e.ChatMessage.Message}");
            }
        }

        private void PSClient_OnLog(object sender, TwitchLib.PubSub.Events.OnLogArgs e)
        {
            if (LogTxt != null)
            {
                LogTxt(e.Data.ToString());
            }
        }

        private void Client_OnChatCommandRecieved(object sender, OnChatCommandReceivedArgs e)
        {
            switch (e.Command.CommandText.ToLower())
            {
                case "cookie":
                    SendMsg("Here's a cookie for you " + e.Command.ChatMessage.Username + " HolidayCookie");
                    break;
                case "roll":
                    string msg = $"{e.Command.ChatMessage.DisplayName} Rolled {RndInt(1, 6)}";
                    client.SendMessage(TwitchInfo.ChannelName, msg);
                    Console.WriteLine($"[Bot]: {msg}");
                    break;
                case "social":
                    client.SendMessage(TwitchInfo.ChannelName, "Here are all my social links! YouTube: http://bit.ly/3p01GJD Twitter: https://bit.ly/369XH5f Discord: http://bit.ly/36h7zMm.");
                    break;
                case "help":
                    client.SendMessage(TwitchInfo.ChannelName, "There is a panel with all commands and a link to the github repo below, please check it out!");
                    break;
                default:
                    break;
            }

            if (e.Command.ChatMessage.DisplayName == TwitchInfo.ChannelName)
            {
                switch (e.Command.CommandText.ToLower())
                {
                    case "hi":
                        client.SendMessage(TwitchInfo.ChannelName, "Hi Boss");
                        return;
                }
            }
        }

        private void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            if(Connected != null)
            {
                Connected(true);
            }
            Console.WriteLine("[Bot]: Connected successfully!");
        }


        private void Client_OnConnectionError(object sender, OnConnectionErrorArgs e)
        {
            Console.WriteLine(e.Error);
        }

        internal void Disconnect()
        {
            if(Connected != null)
            {
                Connected(false);
            }else
            {
                LogTxt("[Bot]: Connected deligate not recieved!");
            }
            Console.WriteLine("[Bot]: Disconnecting...");
            client.Disconnect();
        }

        public void SendMsg(string msg)
        {
            if (msg != null)
            {
                LogTxt($"[Bot]: {msg}");
                client.SendMessage(TwitchInfo.ChannelName, msg.ToString());
            }
        }

        public TwitchClient GetClient()
        {
            return client;
        }

        private int RndInt(int min, int max)
        {
            int value;

            Random rnd = new Random();

            value = rnd.Next(min, max + 1);

            return value;
        }
    }
}