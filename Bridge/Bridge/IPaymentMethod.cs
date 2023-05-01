using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // Interfața pentru metodele de plată
    public interface IPaymentMethod
    {
        void ProcessPayment();
    }
}
