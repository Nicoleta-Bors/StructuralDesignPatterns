using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Menu
    {
        private List<IMenuProduct> _menuItems;

        public Menu()
        {
            _menuItems = new List<IMenuProduct>();
        }

        public void AddItem(IMenuProduct menuItem)
        {
            _menuItems.Add(menuItem);
        }

        public void Show()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("==============================");

            foreach (IMenuProduct menuItem in _menuItems)
            {
                Console.WriteLine("Name: {0}", menuItem.Name);
                Console.WriteLine("Description: {0}", menuItem.Description);
                Console.WriteLine("Quantity: {0} gr", menuItem.Quantity);
                Console.WriteLine("Price: {0} lei", menuItem.Price);
                Console.WriteLine("==============================");
            }
        }
    }
}
