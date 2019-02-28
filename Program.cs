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
            Product product = new Product("Milk", 0);
            product.NameChanged += ProductNameChanged;
            product.Name = "Молоко";
            product.PriceChanged += ProductPriceChanged;
            product.Price = 75;  
            Console.ReadKey();
            /* 
             * TODO #6 Назначить обработчики событий в текущем контексте 
             */

            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */
        }
        private static void ProductNameChanged(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine("Продукту изменили имя с {0} на {1}", args.Old, args.Current);
        }
        private static void ProductPriceChanged(object sender, PriceChangeEventArgs args)
        {
            Console.WriteLine("Продукту изменили цену с {0} на {1}", args.Old, args.Current);
        }
        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */

    }
}
