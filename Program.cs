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
            product.NameChanged += OnProductNameChanged;
            product.PriceChanged += OnProductPriceChanged;
            product.Name = "New IPhone";
            product.Price = 10000999;
            /* 
             * TODO #6 Назначить обработчики событий в текущем контексте 
             */

            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */
        }


        private static void OnProductNameChanged(object sender, ProductNameChangedEventArgs e)
        {
            Console.WriteLine("Было -" + e.OldName + ". Стало -" + e.NewName);
        }

        private static void OnProductPriceChanged(object sender, ProductPriceChangedEventArgs e)
        {

            Console.WriteLine("Was - " + e.OldPrice + ". And now - " + e.NewPrice);
        }
        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */

    }
}
