using System;

namespace DecoratorCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee espresso = new Espresso();
            printCoffee(espresso);
            
            // wrap a espresso coffee with milk
            espresso = new WithMilk(espresso);
            printCoffee(espresso);
            
            // wrap a espresso coffee with Sugar
            espresso = new WithSugar(espresso);
            printCoffee(espresso);
        }

        static void printCoffee(Coffee c){
            Console.WriteLine("Cost :" + c.cost() + " , Description :" + c.GetDescription());
        }
    }
}
