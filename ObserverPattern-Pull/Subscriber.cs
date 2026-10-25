using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Subscriber : IObserver
    {
        private string name;
        private YouTubeChannel channel;
        public Subscriber(string name, YouTubeChannel channel)
        {
            this.name = name;
            this.channel = channel;
        }

        public void Update()
        {
            string videoTitle = channel.GetLatestVideoTitle();

            Console.WriteLine(name + " received notification: " + videoTitle);
        }
    }
}
