using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{

    // Composite - Menu
    class Menu : IFoodProduct
    {
        private string _name;
        private List<IFoodProduct> _menuItems;

        public Menu(string name)
        {
            _name = name;
            _menuItems = new List<IFoodProduct>();
        }

        public void AddItem(IFoodProduct item)
        {
            _menuItems.Add(item);
        }

        public void RemoveItem(IFoodProduct item)
        {
            _menuItems.Remove(item);
        }

        public void Display()
        {
            Console.WriteLine(_name);

            foreach (IFoodProduct item in _menuItems)
            {
                item.Display();
            }
        }

        public decimal GetPrice()
        {
            decimal totalPrice = 0m;

            foreach (IFoodProduct item in _menuItems)
            {
                totalPrice += item.GetPrice();
            }

            return totalPrice;
        }
    }
}
