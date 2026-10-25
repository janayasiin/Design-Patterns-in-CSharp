using System;

namespace ConsoleApp1
{
    public class VIPSubscriber : IObserver
    {
        private string name;
        private YouTubeChannel channel;

        public VIPSubscriber(string name, YouTubeChannel channel)
        {
            this.name = name;
            this.channel = channel;
        }

        public void Update()
        {
            string videoTitle = channel.GetLatestVideoTitle();

            Console.WriteLine("[VIP] " + name +
                " got an exclusive notification: " + videoTitle);
        }
    }
}