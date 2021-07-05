using System;

namespace DecoratorCS
{
    class WithMilk : CoffeeDecorator
    {
        Coffee coffee;
        public WithMilk(Coffee coff){
            this.coffee = coff;
        }
        public override string GetDescription() {
            return coffee.GetDescription() + ", Milk";
        }

        public override double cost(){
            return coffee.cost() + .01;
        }
    }
}
