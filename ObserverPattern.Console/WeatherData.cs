using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ConsoleApp
{
    public class WeatherData : ISubject
    {
        private readonly IList<IObserver> _observers;

        private int _tempery;
        private int _umity;
        private int _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void DataChange(int tempery, int umity, int pressure)
        {
            _tempery = tempery;
            _umity = umity;
            _pressure = pressure;
            
            NotifyObservers();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            var update = new TimeInfosDto()
            {
                Tempery = _tempery,
                Pressure = _pressure,
                Umity = _umity
            };

            foreach (var observer in _observers)
            {
                observer.Update(update);    
            }
        }
    }
}
