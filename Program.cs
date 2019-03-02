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
            product.NameChanged += ProductNameChanged;
            product.PriceChanged += ProductPriceChanged;
            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */
            product.Name = "Телевизор Sony";
            product.Price = 80000;
        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */
        private static void ProductNameChanged(object sender, ProductEventArgs<string> args)
        {
            Console.WriteLine("Название товара '{0}' изменилось на '{1}'", args.Oldvalue, args.Newvalue);
        }

        private static void ProductPriceChanged(object sender, ProductEventArgs<decimal> args)
        {
            Console.WriteLine("Старая цена  равная {0} была изменена на {1}", args.Oldvalue, args.Newvalue);
        }
    }
}