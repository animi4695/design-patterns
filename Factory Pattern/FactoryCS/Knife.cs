using System;

namespace FactoryCS
{
    public class Knife
    {
        // To keep things simple, I'm not creating a separate Chef and Steak Knives class.
        string name;

        public Knife() {
            this.name = null;
        }

        public Knife ChefKnife(){
            Knife knife = new Knife();
            knife.name = "Chef";
            return knife;
        }

        public Knife SteaKnife(){
            Knife knife = new Knife();
            knife.name = "Steak";
            return knife;
        }

        public void Sharpen(string knifeType){
            Console.WriteLine("Sharpening " + knifeType + " knife");
        }

        public void Polish(string knifeType){
            Console.WriteLine("Polishing " + knifeType + " knife");
        }

        public void Pack(string knifeType){
            Console.WriteLine("Packing " + knifeType + " Knife");
        }
    }
}
