using System;

namespace DecoratorCS
{
    abstract class Coffee
    {
        public string description = "Unknown Coffee";
        public virtual string GetDescription() {
            return this.description;
        }

        public abstract double cost();
    }
}
