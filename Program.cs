using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            product.NameChanged += OnNameChanged;
            product.PriceChanged += OnPriceChanged;
            product.Price = 100;
            product.Name = "Another name";

            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */
        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */
        private static void OnPriceChanged(object sender, ProductEventArgs<decimal> a)
        {
            Console.WriteLine("Товар '{0}' сменил цену с {1} на {2}", ((Events.Product)sender).Name, a.OldValue, a.NewValue);
        }

        private static void OnNameChanged(object sender, ProductEventArgs<string> b)
        {
            Console.WriteLine("Товар '{0}' сменил имя на '{1}'", b.OldValue, b.NewValue);
        }

    }
}