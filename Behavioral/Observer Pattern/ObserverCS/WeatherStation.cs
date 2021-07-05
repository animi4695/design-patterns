using System.Collections.Generic;
using System;

namespace ObserverCS
{
    class WeatherStation : ISubject
    {
        private List<IObserver> observers;
        private int temp;
        private int humidity;

        public WeatherStation(){
            this.observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer){
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer){
            observers.Remove(observer);
        }

        public void NotifyObservers(){
            observers.ForEach(x => x.Update(temp, humidity));
        }

        public void MeasurementChanged(int temp, int humidity){
            this.temp = temp;
            this.humidity = humidity;
            NotifyObservers();
        }
    }
}
