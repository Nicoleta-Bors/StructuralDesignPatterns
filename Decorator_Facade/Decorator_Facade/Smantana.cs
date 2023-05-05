using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Facade
{

    // Concrete decorator class
    class Smantana : ToppingDecorator
    {
        public Smantana(FoodIProduct foodProduct) : base(foodProduct)
        {
        }

        public override string GetDescription()
        {
            return foodProduct.GetDescription() + ", Smantana";
        }

        public override double GetPrice()
        {
            return foodProduct.GetPrice() + 10;
        }
    }
}
