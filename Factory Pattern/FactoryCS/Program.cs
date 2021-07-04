using System;

namespace FactoryCS
{
    class Program
    {
        static void Main(string[] args)
        {
            KnifeStore knifeStore = new KnifeStore(new KnifeFactory());
            knifeStore.OrderKnife("CHEF");
        }
    }
}
