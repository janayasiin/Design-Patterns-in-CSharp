using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create YouTube Channel (Subject)
            YouTubeChannel channel = new YouTubeChannel();

            // Create Subscribers (Observers)
            Subscriber s1 = new Subscriber("Janna");
            Subscriber s2 = new Subscriber("Maya");
            Subscriber s3 = new Subscriber("Sara");
            // Create VIP Subscriber
            VIPSubscriber vip = new VIPSubscriber("Lana");
            // Register subscribers
            channel.RegisterObserver(s1);
            channel.RegisterObserver(s2);
            channel.RegisterObserver(vip);

            // First video
            channel.UploadVideo("Observer Pattern");

            // Add a new subscriber
            channel.RegisterObserver(s3);

            // Second video
            channel.UploadVideo("Strategy Pattern");

            // Remove Janna
            channel.RemoveObserver(s1);

            // Third video
            channel.UploadVideo("Factory Pattern");

            // Remove VIP Lana
            channel.RemoveObserver(vip);

            // Fourth video
            channel.UploadVideo("Decorator Pattern");
        }
    }
}