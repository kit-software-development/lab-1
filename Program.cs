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
            product.NameChanged += Product_NameChanged;
            product.Name = "Table";
            product.Name = "Window";

            product.PriceChanged += Product_PriceChanged;
            product.Price = 1000;
            product.Price = 2000;
            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */
        }



        private static void Product_NameChanged(object sender, ProductEventArgs e)
        {
            Product product = sender as Product;
            Console.WriteLine("У продукта '{0}' было изменено название на '{1}'!", e.OldValueName, e.NewValueName);
            //throw new NotImplementedException();
        }

        private static void Product_PriceChanged(object sender, ProductEventArgs e)
        {
            Product product = sender as Product;
            Console.WriteLine("У продукта была изменена стоимость с '{0}' на '{1}'!", e.OldValuePrice, e.NewValuePrice);
            //throw new NotImplementedException();
        }
        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */

    }
}
