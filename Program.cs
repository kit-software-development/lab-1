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

            product.NameChanged += OnProductNameChanged;
            product.PriceChanged += OnProductPriceChanged;

            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */

            product.Name = "Книга";
            product.Price = 420;
            Console.Read();
        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */
      
        private static void OnProductNameChanged(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine("Наименование {0} изменено на {1}", args.Old, args.Current);
        }

        private static void OnProductPriceChanged(object sender, PriceChangeEventArgs args)
        {
            Console.WriteLine("Цена {0} изменена на {1}", args.Old, args.Current);
        }
    }
}
