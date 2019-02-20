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
            }
        }

        static void Main(string[] args)
        {
            Product product = new Product("Some product name", 0);
            
            /* 
             * TODO #7 Назначить обработчики событий в текущем контексте 
             */

            /*
             * TODO #8 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */
        }

        /* 
         * TODO #9 Добавить определение обработчиков событий 
         */

    }
}
