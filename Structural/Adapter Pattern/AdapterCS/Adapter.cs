using System;

namespace AdapterCS
{
    public class Adapter : IUSASocket
    {
        private IEuropeanSocket socket;

        public void Plugin(IEuropeanSocket outlet){
            this.socket = outlet;
        }

        public int Voltage(){
            return 110;
        }

        public int Live() {
            return socket.Live();
        }

        public int Neutral() {
            return socket.Neutral();
        }
    }
}
