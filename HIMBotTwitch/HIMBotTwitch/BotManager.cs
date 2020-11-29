using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client;
using TwitchLib.Client.Models;
using TwitchLib.Client.Events;
using TwitchLib.PubSub;
using TwitchLib.PubSub.Events;
using System.Media;

namespace HIMBotTwitch
{
    class BotManager
    {
        private readonly ConnectionCredentials creds = new ConnectionCredentials(TwitchInfo.ChannelName, TwitchInfo.BotToken);
        private TwitchClient client;
        private TwitchPubSub pubSubClient;

        public Action<bool> Connected;
        public Action<string> LogTxt;

        private SoundPlayer _audio = new SoundPlayer(@"C:\Users\HiImMike\Desktop\Games\#01\Game #01\Assets\SFX\334756__dneproman__ma-sfx-snes-coins-2.wav");

        internal void Connect(bool isLogging)
        {
            LogTxt("[Bot]: Initializing...");
            client = new TwitchClient();
            pubSubClient = new TwitchPubSub();

            // TwitchLib Client
            client.Initialize(creds, TwitchInfo.ChannelName);
            client.OnConnectionError += Client_OnConnectionError;
            client.OnConnected += Client_OnConnected;
            client.OnChatCommandReceived += Client_OnChatCommandRecieved;
            client.OnMessageReceived += Client_OnMessageReceived;

            // PubSub Client
            pubSubClient.OnPubSubServiceConnected += PSClient_OnPubSubServiceConnected;
            pubSubClient.OnListenResponse += PSClient_OnListenResponse;
            pubSubClient.OnViewCount += PSClient_OnViewCount;
            pubSubClient.OnFollow += PSClient_OnFollow;
            pubSubClient.OnMessageDeleted += PSClient_OnMessageDeleted;

            if (isLogging)
            {
                pubSubClient.OnLog += PSClient_OnLog;
            }

            pubSubClient.ListenToVideoPlayback(TwitchInfo.ChannelName);
            pubSubClient.ListenToFollows(TwitchInfo.ChannelName);
            pubSubClient.ListenToCommerce(TwitchInfo.ChannelName);
            pubSubClient.ListenToBitsEvents(TwitchInfo.ChannelName);
            pubSubClient.ListenToRaid(TwitchInfo.ChannelName);
            pubSubClient.ListenToRewards(TwitchInfo.ChannelName);


            client.Connect();
            pubSubClient.Connect();
        }

        private void PSClient_OnListenResponse(object sender, OnListenResponseArgs e)
        {
            if (!e.Successful)
            {
                LogTxt($"{e.Response}");
            }
        }

        private void PSClient_OnPubSubServiceConnected(object sender, EventArgs e)
        {
            pubSubClient.SendTopics(TwitchInfo.BotToken);
        }

        private void PSClient_OnMessageDeleted(object sender, OnMessageDeletedArgs e)
        {
            _audio.Play();
            LogTxt(e.DeletedBy.ToString());
        }

        private void PSClient_OnFollow(object sender, OnFollowArgs e)
        {
         _audio.Play();
            for (int i = 0; i < 1000; i++)
            {
                LogTxt(i + "NEW FOLLOWER!!!!");
            }
        }

        private void PSClient_OnViewCount(object sender, OnViewCountArgs e)
        {
            LogTxt("Views: " + e.Viewers.ToString());
            LogTxt("ServerTime: " + e.ServerTime.ToString());

        }

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
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
                    return;
                default:
                    break;
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
            }
            Console.WriteLine("[Bot]: Disconnecting...");
            client.Disconnect();
        }

        public void SendMsg(string msg)
        {
            if (msg != null)
            {
                Console.WriteLine(msg);
                client.SendMessage(TwitchInfo.ChannelName, msg.ToString());
            }
        }

        public TwitchClient GetClient()
        {
            return client;
        }
    }
}
