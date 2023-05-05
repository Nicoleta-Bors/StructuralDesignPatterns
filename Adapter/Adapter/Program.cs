using System;
using System.Collections.Generic;

namespace Adapter
{
    // Implementăm clasa Program, care conține metoda Main
    class Program
    {
        static void Main(string[] args)
        {
            // Creăm o instanță a meniului
            Menu menu = new Menu();

            // Adăugăm elemente de meniu vechi
            MenuProductOld menuProductOld1 = new MenuProductOld { ProductName = "Domnească cu brânză", Desc = "Aluat foietaj crocant, brânză de vaci, ou de găină, unt, condimente", Quant = 370, ProductCost = 75m };
            MenuProductOld menuProductOld2 = new MenuProductOld { ProductName = "Plăcintă cu cașcaval", Desc = "Aluat subțire, cascaval", Quant = 320, ProductCost = 57m };

            // Adăugăm elemente de meniu noi
            MenuProductNew menuProductNew1 = new MenuProductNew { Name = "Plăcintă cu vișine", Description = "Aluat delicat subțire, cireșe în suc propriu, zahăr pudră", Quantity = 320, Price = 60m };
            MenuProductNew menuProductNew2 = new MenuProductNew { Name = "Plăcintă cu cartofi", Description = "Aluat subțire fraged, cartofi, ceapă prăjită, condimente.", Quantity = 320, Price = 45m };

            //Folosim adapter pentru a extinde meniul vechi cu cel nou
            MenuProductOldAdapter menuProductOldAdapter1 = new MenuProductOldAdapter(menuProductOld1);
            MenuProductOldAdapter menuProductOldAdapter2 = new MenuProductOldAdapter(menuProductOld2);


            menu.AddProduct(menuProductOldAdapter1);
            menu.AddProduct(menuProductOldAdapter2);
            menu.AddProduct(menuProductNew1);
            menu.AddProduct(menuProductNew2);

            // Afișăm meniul complet
            menu.Show();
        }
    }
}