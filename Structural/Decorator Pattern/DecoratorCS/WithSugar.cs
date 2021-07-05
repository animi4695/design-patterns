using System;

namespace DecoratorCS
{
    class WithSugar : CoffeeDecorator
    {
        Coffee coffee;
        public WithSugar(Coffee coff){
            this.coffee = coff;
        }
        public override string GetDescription() {
            return coffee.GetDescription() + ", Sugar";
        }

        public override double cost(){
            return coffee.cost() + .01;
        }
    }
}
