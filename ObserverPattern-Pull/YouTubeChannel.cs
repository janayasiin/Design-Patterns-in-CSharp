using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class YouTubeChannel : ISubject
    {
        private List<IObserver> subscribers = new List<IObserver>();
        public void NotifyObservers()
        {
            foreach (IObserver observer in subscribers)
            {
                observer.Update();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            subscribers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
          subscribers.Remove(observer);
        }

        public void UploadVideo(string videoTitle)
        {
            latestVideoTitle = videoTitle;

            Console.WriteLine("Channel uploaded: " + videoTitle);

            NotifyObservers();
        }
        private string latestVideoTitle;

        public string GetLatestVideoTitle()
        {
            return latestVideoTitle;
        }


    }
}
