using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Facade
{
    // Decorator abstract class
    abstract class ToppingDecorator : FoodItem
    {
        protected FoodItem foodItem;

        public ToppingDecorator(FoodItem foodItem)
        {
            this.foodItem = foodItem;
        }

        public override string GetDescription()
        {
            return foodItem.GetDescription();
        }

        public override double GetPrice()
        {
            return foodItem.GetPrice();
        }
    }

}
