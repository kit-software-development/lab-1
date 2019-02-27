using System;

namespace Events
{
    class Program
    {
        internal Product Product
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        static void Main()
        {
            Product product = new Product("Some product name", 0);
            
            /* 
             * TODO #6 Назначить обработчики событий в текущем контексте 
             */

            Product.EventNameChangeHandler += OnProductNameChangeNotifier;
            Product.EventPriceChangeHandler += OnProductPriceChangeNotifier;

            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */

            product.Name = "Test";
            product.Price = 300;

            product.Name = "Keyboard";
            product.Price = 900;
            product.Price = 950;

            product.Name = null;
            product.Price = 0;

            Console.ReadKey();
        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */

        static void OnProductPriceChangeNotifier(object sender, ProductEventArgs args)
        {
            var product = sender as Product;
            if (product != null) Console.WriteLine("Price changed: {0} -> {1}", args.OldPrice, product.Price);
            else
            {
                throw new Exception("Product is null!");
            }
        }

        static void OnProductNameChangeNotifier(object sender, ProductEventArgs args)
        {
            var product = sender as Product;
            if (product != null) Console.WriteLine("Name changed: \"{0}\" -> \"{1}\"", args.OldName, product.Name);
            else
            {
                throw new Exception("Product is null!");
            }
        }
    }
}
