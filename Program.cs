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
            product.Name = "Product1";
            product.Name = "NewProduct";
            product.Price = 5677;
            product.Price = 678;
        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */
        private static void ProductNameChanged(object sender, ProductEventArgs e)
        {
            Product product = sender as Product;
            Console.WriteLine("Name of {0} has changed to {1}", e.Prev_Name, e.New_Name);
        }

        private static void ProductPriceChanged(object sender, ProductEventArgs e)
        {
            Product product = sender as Product;
            Console.WriteLine("Price has changed from {0} to {1}", e.Prev_Price, e.New_Price);
        }

    }
}
