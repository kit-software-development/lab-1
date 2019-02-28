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
            product.Name = "Another product name";
            product.Price = 300;
        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */
        private static void OnProductNameChanged(object sender, ProductEventArgs e)
        {
            Console.WriteLine("The name of the product was changed from '{0}' to '{1}'", e.Old, e.Current);
        }
        private static void OnProductPriceChanged(object sender, ProductEventArgs e)
        {
            Console.WriteLine("The price of the product was changed from '{0}' to '{1}'", e.Old, e.Current);
        }
    }
}
