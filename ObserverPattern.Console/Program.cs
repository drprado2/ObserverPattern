using System;
using System.Threading;

namespace ObserverPattern.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new WeatherData();

            var obs1 = new PresentationalOne();
            var obs2 = new PresentationalTwo();
            var obs3 = new PresentationalTree();

            subject.AddObserver(obs1);
            subject.AddObserver(obs2);
            subject.AddObserver(obs3);

            while (true)
            {
                subject.DataChange(10 + DateTime.Now.Second, 25 + DateTime.Now.Second, 35 + DateTime.Now.Second);
                Thread.Sleep(5000);
            }
        }
    }
}
