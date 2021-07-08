using System;

namespace AdapterCS
{

    // Client
    public class ElectricKettle
    {
        IUSASocket power;

        public void Plugin(IUSASocket supply){
            power = supply;
        }

        public void Boil(){
            if(power.Voltage() > 110) {
                Console.WriteLine("Kettle is on Fire");
                return;
            }

            Console.WriteLine("Coffee ready");
        }
    }
}
