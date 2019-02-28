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

            product.NameChanged += ProductNameChanged;
            // ...
            product.Name = "Plate";

            product.PriceChanged += ProductPriceChanged;
            // ...
            product.Price = 55;
            Console.Read();
            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */
        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */
        private static void ProductNameChanged(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine("Название продукта {0} изменено с '{0}' на '{1}'", args.Old, args.Current);
        }

        private static void ProductPriceChanged(object sender, PriceChangeEventArgs args)
        {
            Console.WriteLine("Цена продукта изменена с '{0}' на '{1}'", args.Old, args.Current);
        }
        
    }
}
