using HIMBotTwitch;
using System;
using TwitchLib.Client;

namespace HIMBot
{
    internal class Announcement
    {
        public Announcement(TwitchClient _client, string _announcement, TimeSpan _interval)
        {
            var start = TimeSpan.Zero;
            var announce = new System.Threading.Timer((e) => {
            _client.SendMessage(TwitchInfo.ChannelName, _announcement);
            }, null, start, _interval);
        }
    }
}