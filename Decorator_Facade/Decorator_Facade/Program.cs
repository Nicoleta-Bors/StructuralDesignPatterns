using System;
using System.Collections.Generic;

namespace Decorator_Facade
{

    class Program
    {
        static void Main(string[] args)
        {
            FoodFacade foodFacade = new FoodFacade();

            Console.WriteLine("Bors cu ardei:");
            Console.WriteLine(foodFacade.GetBorsWithArdei());

            Console.WriteLine("\nColtunasi cu smantana:");
            Console.WriteLine(foodFacade.GetColtunasiWithSmantana());
        }
    }
}