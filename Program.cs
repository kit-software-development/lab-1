using System;
using System.Globalization;

namespace Events
{
    public class Program
    {
        private Product Product { get; set; }

        private static void Main(string[] args) => new Program().Run();

        private void Run()
        {
            Product = new Product("Some product name", 0);
            Product.NameChanged += OnNameChanged;
            Product.PriceChanged += OnPriceChanged;
            Product.Name = "New awesome product";
            Product.Price = 1000.500m;
        }

        private void OnPriceChanged(object sender, ProductChangedEventArgs<decimal> e)
        {
            Console.WriteLine($"Продукт \"{((Product) sender).Name}\" " +
                              $"сменил цену с {e.OldValue} на {e.NewValue}");
        }

        private void OnNameChanged(object sender, ProductChangedEventArgs<string> e)
        {
            Console.WriteLine($"Продукт \"{((Product) sender).Name}\" " +
                              $"сменил название с \"{e.OldValue}\" на \"{e.NewValue}\"");
        }
    }
}