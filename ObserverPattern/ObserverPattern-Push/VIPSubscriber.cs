using System;

namespace ConsoleApp1
{
    public class VIPSubscriber : IObserver
    {
        private string name;

        public VIPSubscriber(string name)
        {
            this.name = name;
        }

        public void Update(string videoTitle)
        {
            Console.WriteLine("[VIP] " + name +
                " got an exclusive notification: " + videoTitle);
        }
    }
}