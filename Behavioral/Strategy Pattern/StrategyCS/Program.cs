using System;

namespace StrategyCS
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyBehavior flyWithWings = new FlyWithWings();
            FlyBehavior noFly = new NoFly();

            // we can change the behavior at any time for the mallard duck
            Duck mallardDuck = new MallardDuck(flyWithWings);
            mallardDuck.PerformFly();
            
            mallardDuck = new MallardDuck(noFly);
            mallardDuck.PerformFly();
        }
    }
}
