using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // Clasa abstractă pentru comanda de mâncare
    public abstract class FoodOrder
    {
        protected IPaymentMethod paymentMethod;

        public FoodOrder(IPaymentMethod paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        public abstract void DisplayOrderDetails();
    }
}
