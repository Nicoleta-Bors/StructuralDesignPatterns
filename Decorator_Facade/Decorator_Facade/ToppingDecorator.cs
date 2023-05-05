using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Facade
{
    // Decorator abstract class
    abstract class ToppingDecorator : FoodIProduct
    {
        protected FoodIProduct foodProduct;

        public ToppingDecorator(FoodIProduct foodProduct)
        {
            this.foodProduct = foodProduct;
        }

        public override string GetDescription()
        {
            return foodProduct.GetDescription();
        }

        public override double GetPrice()
        {
            return foodProduct.GetPrice();
        }
    }

}
