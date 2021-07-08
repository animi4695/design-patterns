using System;

namespace AdapterCS
{
    public interface IEuropeanSocket
    {
        int Voltage();
        int Live();
        int Earth();
        int Neutral();
    }
}
