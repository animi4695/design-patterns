using System;

namespace AdapterCS
{
    public class Socket : IEuropeanSocket
    {
        public int Voltage() {
            return 220;
        }

        public int Live(){ return 1; }

        public int Earth() { return 0; }

        public int Neutral() { return -1; }
    }
}
