using System;
using System.IO;

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
            Product.NameChangeHandler += OnProductNameChangeMessage;
            Product.PriceChangeHandler += OnProductPriceChangeNotification;

            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */

            product.Name = "AMD Ryzen 2600X";
            product.Price = 250;

            product.Name = "AMD Ryzen 2600X Is best";
            product.Price = 200;
            product.Price = 10000;
        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */

        static void OnProductNameChangeMessage(object sender, ProductEventArgs args)
        {
            Product product = sender as Product;
            Console.WriteLine("We renamed our product from '" + args.OldName + "' to '" + product.Name + "'. Hurry up to buy!");
        }

        static void OnProductPriceChangeNotification(object sender, ProductEventArgs args)
        {
            Product product = sender as Product;
            if (args.OldPrice == 0)
            {
                Console.WriteLine("We set a price for product '" + product.Name + "'. Now it's available to buy for $" + product.Price);
            }
            else
            {
                if (args.OldPrice - product.Price > 0)
                { 
                    Console.WriteLine("SALE SALE SALE ! '" + product.Name + "' got a " + Math.Round((1 - product.Price / args.OldPrice)*100)  + " % discount! Buy it for $" + product.Price);
                }
                else
                {
                    Console.WriteLine("Oh no... '" + product.Name + "' is now more expensive. New price is $" + product.Price);
                }
            }
        }

    }
}
