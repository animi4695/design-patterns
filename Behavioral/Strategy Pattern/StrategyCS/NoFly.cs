using System;

namespace StrategyCS
{
    public class NoFly : FlyBehavior
    {
        public void Fly(){
            Console.WriteLine("I can't fly.");
        }
    }
}
