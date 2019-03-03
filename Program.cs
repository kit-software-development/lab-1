using System;

namespace Events
{
    class Program
    {

        static void Main(string[] args)
        {
            Product product = new Product("Milk", 70);
            product.NameChange += OnNameChanged;
            product.PriceChange += OnPriceChanged;

            Console.WriteLine("Starting...");
            product.Name = "Fresh Milk";
            product.Price = 80;
            Console.WriteLine("Finished");

            Console.ReadLine();
        }

        private static void OnPriceChanged(object sender, ProductEventArgs e)
        {
            Console.WriteLine("Price of " + e.NewName + " changed from " + e.OldPrice + " to " + e.NewPrice);
        }

        private static void OnNameChanged(object sender, ProductEventArgs e)
        {
            Console.WriteLine("Name of " + e.OldName + " changed to " + e.NewName);
        }
    }
}