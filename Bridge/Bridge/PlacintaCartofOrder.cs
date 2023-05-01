using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class PlacintaCartofOrder : FoodOrder
    {
        public PlacintaCartofOrder(IPaymentMethod paymentMethod) : base(paymentMethod)
        {
        }

        public override void DisplayOrderDetails()
        {
            Console.WriteLine("Ai comandat o placinta cu cartofi.");
            paymentMethod.ProcessPayment();
        }
    }
}
