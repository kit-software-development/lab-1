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
            /* 
             * TODO #6 Назначить обработчики событий в текущем контексте 
             */
            Product.event_NameChange += ProductNameChanger;
            Product.event_PriceChange += ProductPriceChanger;

            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */

            product.Name = "sadasda";
            product.Price = 1;
            product.Name = "test";
            product.Name = "ttttt";
            product.Price = 822;
            product.Price = 5452;

            Console.ReadKey();
        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */

        static void ProductNameChanger(object sender, ProductEventArgs args)
        {
            var product = sender as Product;
            Console.WriteLine("Name of {0} has changed to {1}", args.OldName, product.Name);
        }

        static void ProductPriceChanger(object sender, ProductEventArgs args)
        {
            var product = sender as Product;
            Console.WriteLine("Price of {0} has changed from {1} to {2}", product.Name, args.OldPrice, product.Price);
        }
    }
}
