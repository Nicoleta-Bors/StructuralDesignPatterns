using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class OnlinePayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Plata online.");
        }
    }
}
