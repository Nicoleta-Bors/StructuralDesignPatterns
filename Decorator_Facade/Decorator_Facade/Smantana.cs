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
        public Smantana(FoodItem foodItem) : base(foodItem)
        {
        }

        public override string GetDescription()
        {
            return foodItem.GetDescription() + ", Smantana";
        }

        public override double GetPrice()
        {
            return foodItem.GetPrice() + 10;
        }
    }
}
