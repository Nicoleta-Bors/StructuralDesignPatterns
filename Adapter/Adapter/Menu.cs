using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Menu
    {
        private List<IMenuProduct> _menuProducts;

        public Menu()
        {
            _menuProducts = new List<IMenuProduct>();
        }

        public void AddProduct(IMenuProduct menuProduct)
        {
            _menuProducts.Add(menuProduct);
        }

        public void Show()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("==============================");

            foreach (IMenuProduct menuProduct in _menuProducts)
            {
                Console.WriteLine("Name: {0}", menuProduct.Name);
                Console.WriteLine("Description: {0}", menuProduct.Description);
                Console.WriteLine("Quantity: {0} gr", menuProduct.Quantity);
                Console.WriteLine("Price: {0} lei", menuProduct.Price);
                Console.WriteLine("==============================");
            }
        }
    }
}
