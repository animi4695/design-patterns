using System.Collections.Generic;
using System;

namespace ObserverCS
{
    class ForecastDisplay : IObserver
    {
       private List<int> tempHistory;
       private List<int> humidityHistory;

       public ForecastDisplay(ISubject weatherStation){
           weatherStation.RegisterObserver(this);
           this.tempHistory = new List<int>();
           this.humidityHistory = new List<int>();
       }

       public void Update(int temp, int humidity){
           this.tempHistory.Add(temp);
           this.humidityHistory.Add(humidity);
           Display7DayHistory();
       }

       public void Display7DayHistory(){
           Console.WriteLine("Temp History & Humidity History");
           for(int i = 0; i < Math.Min(7, tempHistory.Count); i++){
               Console.WriteLine(tempHistory[i] + " " + humidityHistory[i]);
           }
       }
    }
}
