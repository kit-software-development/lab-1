using System;


namespace Events
{
    class Program
    {
  
        
        static void Main(string[] args)
        {
                       
            /* 
             * TODO #6 Назначить обработчики событий в текущем контексте 
             */

            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */

            Product product = new Product("Some product name", 0);
            product.NameChanged += OnNameChanged;
            product.PriceChanged += OnPriceChanged;
            product.Name = "Холодильник";
            product.Price = 10000;

        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */

        private static void OnNameChanged (object sender, ProductEventArgs<string> args)
        {
            Console.WriteLine("Название товара '{0}' изменилось на '{1}'", args.Oldvalue, args.Newvalue);
        }

        private static void OnPriceChanged(object sender, ProductEventArgs<decimal> args)
        {
            Console.WriteLine("Старая цена товара {0} равная {1} была изменена на {2}", ((Product) sender).Name, args.Oldvalue, args.Newvalue);
        }

    }
}
