using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // create menu products
            MenuProduct bors = new MenuProduct("Bors rosu", 50m);
            MenuProduct carnaciori = new MenuProduct("Cârnăciori la grill cu cartofi", 105m);
            MenuProduct compot = new MenuProduct("Compot de fructe de padure ", 25m);
            MenuProduct salata = new MenuProduct("Salata taraneasca", 70m);

            // create sub-menus
            Menu mainMenu = new Menu("Meniul zilei");
            Menu comboMenu = new Menu("Meniul zilei - Combo");

            // add products to sub-menus
            mainMenu.AddProduct(bors);
            mainMenu.AddProduct(carnaciori);
            mainMenu.AddProduct(compot);

            comboMenu.AddProduct(mainMenu);
            comboMenu.AddProduct(salata);

            // display menus and prices
            Console.WriteLine("Meniuri:");

            mainMenu.Display();
            Console.WriteLine($"Pret total: {mainMenu.GetPrice()} lei\n");

            comboMenu.Display();
            Console.WriteLine($"Pret total: {comboMenu.GetPrice()} lei");

        }
    }
}
