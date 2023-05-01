using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class CashOnDeliveryPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Plata la livrare.");
        }
    }
}
