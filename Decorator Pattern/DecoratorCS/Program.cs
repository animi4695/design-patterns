using System;

namespace DecoratorCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee espresso = new Espresso();
            printCoffee(espresso);
            
            espresso = new WithMilk(espresso);
            printCoffee(espresso);

            espresso = new WithSugar(espresso);
            printCoffee(espresso);
        }

        static void printCoffee(Coffee c){
            Console.WriteLine("Cost :" + c.cost() + " , Description :" + c.GetDescription());
        }
    }
}
