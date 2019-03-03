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
            product.nameChanged += onNameChanged;
            product.priceChanged += onPriceChanged;

            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */

            product.Name = "NewNewNew";
            product.Price = 1000;
        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */

        private static void onNameChanged(object sender, ProductEventArgs e)
        {
            Product product = sender as Product;
            Console.WriteLine("Name has been changed from " + e.oldName + " to " + product.Name);
        }

        private static void onPriceChanged(object sender, ProductEventArgs e)
        {
            Product product = sender as Product;
            Console.WriteLine("Price has been changed from " + e.oldPrice + " to " + product.Price);
        }

    }
}
