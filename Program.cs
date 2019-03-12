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
            Product product = new Product("Car", 1000);

            product.NameChanged += OnNameChanged;
            product.PriceChanged += OnPriceChanged;
            product.Name = "Super Car";
            product.Price = 10839;
        }

        private void OnPriceChanged(Product sender, ProductChangedEventArgs<decimal> e)
        {
            Console.WriteLine("Цена продукта [0] изменилась с [1] на [2]", sender.Name, e.OldValue, e.NewValue);
        }

        private void OnNameChanged(Product sender, ProductChangedEventArgs<string> e)
        {
            Console.WriteLine("Название продукта [0] изменилось с [1] на [0]", e.NewValue,e.OldValue);
        }

    }
}

