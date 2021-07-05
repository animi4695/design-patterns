using System.Threading;
using System;

namespace ObserverCS
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            CurrentConditionsDisplay  currentConditions = new CurrentConditionsDisplay(weatherStation);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherStation);

            for(int i = 0; i < 5; i++){
                Console.WriteLine("--------- Update " + i + "----------");
                int randomTemp = new Random().Next(-40, 90);
                int randomHumidity = new Random().Next(-10, 80);

                weatherStation.MeasurementChanged(randomTemp, randomHumidity);

                Thread.Sleep(1000);
            }

        }
    }
}
