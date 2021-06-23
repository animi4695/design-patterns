using System;

namespace StrategyCS
{
    public class MallardDuck : Duck
    {
        public MallardDuck(FlyBehavior flyBehavior) : base(flyBehavior){

        }

        public void PerformFly() {
            flyBehavior.Fly();
        }


    }
}
