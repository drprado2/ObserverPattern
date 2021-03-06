﻿using System;

namespace ObserverPattern.ConsoleApp
{
    public class PresentationalTree : IObserver, IWeatherPresentational
    {
        private int _tempery;
        private int _umity;
        private int _pressure; 

        public void Update(TimeInfosDto update)
        {
            _tempery = update.Tempery;
            _umity = update.Umity;
            _pressure = update.Pressure;
        }

        public void Display()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Apresentação 3 foi atualizada");
            Console.WriteLine("Temperatura: " + _tempery);
            Console.WriteLine("Umidade: " + _umity);
            Console.WriteLine("Pressão: " + _pressure);
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        }
    }
}
