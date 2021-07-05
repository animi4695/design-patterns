using System;

namespace StrategyCS
{
    public abstract class Duck
    {
        protected FlyBehavior flyBehavior;

        public Duck(FlyBehavior flyBehavior){
            this.flyBehavior = flyBehavior;
        }

        public void PerformFly(){
            flyBehavior.Fly();
        }
    }
}
