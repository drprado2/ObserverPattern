using System.Data;

namespace ObserverPattern.ConsoleApp
{
    public interface IObserver
    {
        void Update(TimeInfosDto update);
    }
}
