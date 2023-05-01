using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Facade
{
    // Concrete component class
    class Coltunasi : FoodItem
    {
        public override string GetDescription()
        {
            return "Coltunasi";
        }

        public override double GetPrice()
        {
            return 70;
        }
    }
}
