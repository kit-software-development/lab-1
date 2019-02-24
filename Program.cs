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
            Product product = new Product("Some product name", 0);

            product.NameChanged += OnProductNameChanged;
            product.PriceChanged += OnProductPriceChanged;

            product.Name = "Notebook";
            product.Price = 100000;
        }

        private static void OnProductNameChanged(object sender, 
                                                 ProductEventArgs<string> args)
        {
            Console.WriteLine("'{0}' changed his name to '{1}'!",
                              args.PropertyOldValue, args.PropertyNewValue);
        }

        private static void OnProductPriceChanged(object sender,
                                                  ProductEventArgs<decimal> args)
        {
            Console.WriteLine("'{0}' changed his price to '{1}'!",
                              args.PropertyOldValue, args.PropertyNewValue);
        }
    }
}
