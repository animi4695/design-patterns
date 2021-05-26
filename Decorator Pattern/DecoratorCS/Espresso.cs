using System;

namespace DecoratorCS
{
    class Espresso : Coffee
    {
        public Espresso() {
            this.description = "Espresso";
        }

        public override double cost()
        {
            return 1.98;
        }
    }
}
