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

            /*TODO #6 Назначить обработчики событий в текущем контексте*/
            product.NameChanged += OnNameChanged;
            product.PriceChanged += OnPriceChanged;
            /*TODO #7 Выполнить с экземпляром класса Product действия, приводящие к возникновению описанных Вами событий*/
            product.Price = 999;
            product.Name = "Cake";
            Console.ReadKey();
        }

        /*TODO #8 Добавить определение обработчиков событий*/
        private static void OnPriceChanged(object addresser, ProductEventArgs args)
        {
            Console.WriteLine("Price has been changed from {0} to {1}!", args.Prev_Price, args.New_Price);
        }
        private static void OnNameChanged(object addresser, ProductEventArgs args)
        {
            Console.WriteLine("Name has been changed from {0} to {1}!", args.Prev_Name, args.New_Name);
        }
    }
}
