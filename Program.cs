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
            product.NameChangeEvent += OneProductNameChanged;
            product.PriceChangeEvent += OneProductPriceChanged;


            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */
             product.Name = "New name";
             product.Price = 1234;
        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */

        private static void OneProductNameChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void OneProductPriceChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
