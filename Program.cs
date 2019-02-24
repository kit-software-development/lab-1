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
            
            product.nameChanged += onProductNameChanged;
            product.priceChanged += onProductPriceChanged;

            product.name = "iPhone XS";
            product.price = 999;
        }

        // EventHandlers
        
        private static void onProductNameChanged(object sender, ProductEventArgs<string> e)
        {
            Console.WriteLine("Product name \"{0}\" changed to \"{1}\"", e.oldValue, e.newValue);
        }

        private static void onProductPriceChanged(object sender, ProductEventArgs<decimal> e)
        {
            Console.WriteLine("Product price {0} changed to {1}", e.oldValue, e.newValue);
        }

    }
}
