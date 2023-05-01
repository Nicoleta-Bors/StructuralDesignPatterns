using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{

    // Leaf - MenuProduct
    class MenuProduct : IFoodProduct
    {
        private string _name;
        private decimal _price;

        public MenuProduct(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public void Display()
        {
            Console.WriteLine($"- {_name} ({_price} lei)");
        }

        public decimal GetPrice()
        {
            return _price;
        }
    }

}
