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
            MenuProductOld menuItemOld1 = new MenuProductOld { ItemName = "Domnească cu brânză", Desc = "Aluat foietaj crocant, brânză de vaci, ou de găină, unt, condimente", Quant = 370, ItemCost = 75m };
            MenuProductOld menuItemOld2 = new MenuProductOld { ItemName = "Plăcintă cu cașcaval", Desc = "Aluat subțire, cascaval", Quant = 320, ItemCost = 57m };

            // Adăugăm elemente de meniu noi
            MenuProductNew menuItemNew1 = new MenuProductNew { Name = "Plăcintă cu vișine", Description = "Aluat delicat subțire, cireșe în suc propriu, zahăr pudră", Quantity = 320, Price = 60m };
            MenuProductNew menuItemNew2 = new MenuProductNew { Name = "Plăcintă cu cartofi", Description = "Aluat subțire fraged, cartofi, ceapă prăjită, condimente.", Quantity = 320, Price = 45m };

            //Folosim adapter pentru a adapta meniul vechi cu cel nou
            MenuProductOldAdapter menuItemOldAdapter1 = new MenuProductOldAdapter(menuItemOld1);
            MenuProductOldAdapter menuItemOldAdapter2 = new MenuProductOldAdapter(menuItemOld2);


            menu.AddItem(menuItemOldAdapter1);
            menu.AddItem(menuItemOldAdapter2);
            menu.AddItem(menuItemNew1);
            menu.AddItem(menuItemNew2);

            // Afișăm meniul complet
            menu.Show();
        }
    }
}