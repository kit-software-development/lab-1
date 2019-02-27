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

            product.NameChanged += OnProduct_NameChanged;
            product.PriceChanged += OnProduct_PriceChanged;

            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */

            product.Name = "Стол";
            product.Name = "Круглый стол";

            product.Price = 200;
            product.Price = 250;
        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */

        private static void OnProduct_NameChanged(object sender, ProductEventArgs e)
        {
            Product product = sender as Product;
            Console.WriteLine("Наименование товара изменено с '{0}' на '{1}'!", e.OldName, e.NewName);
        }

        private static void OnProduct_PriceChanged(object sender, ProductEventArgs e)
        {
            Product product = sender as Product;
            Console.WriteLine("Стоимость товара изменена с '{0}' на '{1}'!", e.OldPrice, e.NewPrice);
        }

    }
}
