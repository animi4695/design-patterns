using System;

namespace ObserverCS
{
    class CurrentConditionsDisplay : IObserver
    {
       private int temp;
       private int humidity;

       public CurrentConditionsDisplay(ISubject weatherStation){
           weatherStation.RegisterObserver(this);
       }

       public void Update(int temp, int humidity){
           this.temp = temp;
           this.humidity = humidity;
           DisplayCurrent();
       }

       public void DisplayCurrent(){
           Console.WriteLine("Temp : " + temp + " Humidity : " + humidity);
       }
    }
}
