using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Facade
{
    // Concrete component class

    class Bors : FoodIProduct
    {
        public override string GetDescription()
        {
            return "Bors";
        }

        public override double GetPrice()
        {
            return 50;
        }
    }
}
