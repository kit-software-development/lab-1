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
            product.ProductNameChange += ProductNameChange;
            product.ProductPriceChange += ProductPriceChange;
            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */
            product.Name = "hello";
            product.Name = "bye";
            product.Price = 1000;
            product.Price = 1000000;

            Product goods = new Product("bread", 30);
            goods.ProductPriceChange += ProductPriceChange;
            goods.Price = 60;

        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */
        private static void ProductNameChange(object sender, ProductEventArgs arg)
        {
            Console.WriteLine("Название продукта '{0}' изменилось на '{1}'", arg.OldValue, arg.NewValue);
        }
        private static void ProductPriceChange(object sender, ProductEventArgsD arg)
        {
            Console.WriteLine("Цена продукта '{0}'  изменилась c '{1}'на '{2}'", ((Product) sender).Name, arg.OldValue, arg.NewValue);
        }
    }
}
