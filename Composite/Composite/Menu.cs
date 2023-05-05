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
        private List<IFoodProduct> _menuProduct;

        public Menu(string name)
        {
            _name = name;
            _menuProduct = new List<IFoodProduct>();
        }

        public void AddProduct(IFoodProduct product)
        {
            _menuProduct.Add(product);
        }

        public void Display()
        {
            Console.WriteLine(_name);

            foreach (IFoodProduct product in _menuProduct)
            {
                product.Display();
            }
        }

        public decimal GetPrice()
        {
            decimal totalPrice = 0m;

            foreach (IFoodProduct product in _menuProduct)
            {
                totalPrice += product.GetPrice();
            }

            return totalPrice;
        }
    }
}
