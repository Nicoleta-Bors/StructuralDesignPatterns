using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Facade
{
    // Component abstract class
    abstract class FoodItem
    {
        public abstract string GetDescription();
        public abstract double GetPrice();
    }
}
