using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Selectăm modul de plată
            Console.WriteLine("Cum doriti să platiti?");
            Console.WriteLine("1. Plată online");
            Console.WriteLine("2. Plată la livrare");
            int paymentOption = int.Parse(Console.ReadLine());

            IPaymentMethod paymentMethod;
            if (paymentOption == 1)
            {
                paymentMethod = new OnlinePayment();
            }
            else if (paymentOption == 2)
            {
                paymentMethod = new CashOnDeliveryPayment();
            }
            else
            {
                Console.WriteLine("Optiune invalidă de plata.");
                return;
            }

            // Selectăm produsul
            Console.WriteLine("Ce doriti sa comandati?");
            Console.WriteLine("1. Placina cu cartof");
            Console.WriteLine("2. Placina cu visina");
            Console.WriteLine("3. Placina domneasca");
            int productOption = int.Parse(Console.ReadLine());

            // Plasăm comanda folosind modul de plată selectat
            FoodOrder foodOrder;
            if (productOption == 1)
            {
                foodOrder = new PlacintaCartofOrder(paymentMethod);
            }
            else if (productOption == 2)
            {
                foodOrder = new PlacintaVisinaOrder(paymentMethod);
            }
            else if (productOption == 3)
            {
                foodOrder = new PlacintaDomneascaOrder(paymentMethod);
            }
            else
            {
                Console.WriteLine("Optiune invalidă de produs.");
                return;
            }

            // Afișăm detaliile comenzii
            Console.WriteLine("Comanda dvs:");
            foodOrder.DisplayOrderDetails();

        }
    }
}
