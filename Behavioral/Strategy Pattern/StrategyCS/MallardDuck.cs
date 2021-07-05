using System;

namespace StrategyCS
{
    public class MallardDuck : Duck
    {
        public MallardDuck(FlyBehavior flyBehavior) : base(flyBehavior){

        }

        public new void PerformFly() {
            flyBehavior.Fly();
        }


    }
}
