using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class PlacintaDomneascaOrder : FoodOrder
    {
        public PlacintaDomneascaOrder(IPaymentMethod paymentMethod) : base(paymentMethod)
        {
        }

        public override void DisplayOrderDetails()
        {
            Console.WriteLine("Ai comandat o placinta domneasca");
            paymentMethod.ProcessPayment();
        }
    }
}
