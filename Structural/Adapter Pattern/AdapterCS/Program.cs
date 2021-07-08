using System;

namespace AdapterCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket();  // European style
            Adapter adapter = new Adapter(); // supports US style systems to communicate with European style

            ElectricKettle kettle = new ElectricKettle(); // Client

            adapter.Plugin(socket); // Think of pluggin Adapter to European socket
            kettle.Plugin(adapter); // Think of Client pluggin to Adapter.

            // Now the connections looks like USA(client) > Adapter > EU(socket) 

            kettle.Boil();
        }
    }
}
