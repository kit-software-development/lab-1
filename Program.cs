using System;
namespace Events
{
    class Program
    {
        internal Product Product
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
                throw new System.NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
            Product product = new Product("Product name", 0);
            product.NameChanged += OnNameChanged;
            product.PriceChanged += OnPriceChanged;
            product.Name = "Toaster";
            product.Price = 100;

            Console.ReadKey();
        }

        private static void OnNameChanged(object sender, ProductEventArgs<string> args)
        {
            Console.WriteLine("Название товара '{0}' сменилось на '{1}'", args.OldValue, args.NewValue);
        }

        private static void OnPriceChanged(object sender, ProductEventArgs<decimal> args)
        {
            Console.WriteLine("Старая цена товара '{0}' была {1} , стала {2}", ((Product)sender).Name, args.OldValue, args.NewValue);
        }

    }
}
