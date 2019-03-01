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
            product.PriceChanged += ProductPriceChanged;

            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */

            product.Name = "Another product name";
            product.Price = 1;
        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */

        private static void ProductNameChanged(object sender, ProductEventArgs e)
        {
            Console.WriteLine("Название товара было изменено с '{0}' на '{1}'", e.OldName, e.NewName);
        }

        private static void ProductPriceChanged(object sender, ProductEventArgs e)
        {
            Console.WriteLine("Цена товара была изменена с '{0}' на '{1}'", e.OldPrice, e.NewPrice);
        }


    }
}
