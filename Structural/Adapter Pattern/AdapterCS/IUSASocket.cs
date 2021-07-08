using System;

namespace AdapterCS
{
    public interface IUSASocket
    {
        int Voltage();
        int Live();
        int Neutral();
    }
}
