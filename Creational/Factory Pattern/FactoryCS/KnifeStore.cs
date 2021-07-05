using System;

namespace FactoryCS
{
    class KnifeStore
    {
        private KnifeFactory knifeFactory;

        public KnifeStore(KnifeFactory knifeFactory){
            this.knifeFactory = knifeFactory;
        }

        public Knife OrderKnife(string knifeType){
            Knife knife;
            knife = knifeFactory.CreateKnife(knifeType);

            knife.Sharpen(knifeType);
            knife.Polish(knifeType);
            knife.Pack(knifeType);

            return knife;
        }
    }
}
