using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Facade
{
    // Concrete decorator class
    class Ardei : ToppingDecorator
    {
        public Ardei(FoodIProduct foodProduct) : base(foodProduct)
        {
        }

        public override string GetDescription()
        {
            return foodProduct.GetDescription() + ", Ardei";
        }

        public override double GetPrice()
        {
            return foodProduct.GetPrice() + 5.00;
        }
    }
}
