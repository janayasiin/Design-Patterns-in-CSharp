using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Subscriber : IObserver
    {
        private string name;
        public Subscriber(string name)
        {
            this.name = name;
        }

        public void Update(string videoTitle)
        {
            Console.WriteLine(name + " received notification: " + videoTitle);
        }
    }
}
