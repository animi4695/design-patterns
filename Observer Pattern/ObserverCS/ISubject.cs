using System;

namespace ObserverCS
{
    interface ISubject {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}