using System;

namespace Home_Delegates
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
            product.PriceChanged += OnPriceChanged;
            product.NameChanged += OnNameChanged;
            product.Name = "kek";
            product.Price = 100;
            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */
        }

        private static void OnNameChanged(object sender, ProductChangedEventArgs<string> e)
        {
            Console.WriteLine("Товар '{0}' изменил название с '{0}' на '{1}'", e.OldValue, e.NewValue);
        }

        private static void OnPriceChanged(object sender, ProductChangedEventArgs<decimal> e)
        {
            Console.WriteLine("Товар '{0}' изменил цену с '{1}' на '{2}'", ((Product)sender).Name,  e.OldValue, e.NewValue);
        }
        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */

    }
}