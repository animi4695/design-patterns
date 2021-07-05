using System;

namespace SingletonCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // RocketShip rocketShip = new RocketShip();   This will not work since constructor is private
            RocketShip rShip1 = RocketShip.GetInstance();
            RocketShip rShip2 = RocketShip.GetInstance();
            Console.WriteLine(rShip1.Equals(rShip2));
        }
    }
}
