using System;

namespace StrategyCS
{
    public class FlyWithWings : FlyBehavior
    {
        public void Fly(){
            Console.WriteLine("I'm Flying");
        }
    }
}
