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
            product.NameChanged += OnNameChanged;
            product.PriceChanged += OnPriceChanged;

            product.Name = "Apple";
            product.Price= 10;
            Console.ReadKey();
        }

        private static void OnNameChanged(object sender, ProductEventArgs args)
        {
            Console.WriteLine("Name changed from {0} to {1}", args.Old_Name, args.New_Name);
        }
        private static void OnPriceChanged(object sender, ProductEventArgs args)
        {
            Console.WriteLine("Price changed from {0} to {1}", args.Old_Price, args.New_Price);
        }
    }
}
