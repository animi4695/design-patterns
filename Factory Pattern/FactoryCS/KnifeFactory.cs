using System;

namespace FactoryCS
{
    public class KnifeFactory : Knife
    {
        public Knife CreateKnife(string KnifeType){
            Knife knife = null;
            if(KnifeType.ToUpper().Equals("STEAK")){
                knife = SteaKnife();
            }
            else if(KnifeType.ToUpper().Equals("CHEF")){
                knife = ChefKnife();
            }
            return knife;
        }
    }
}
