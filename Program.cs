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
            Product product = new Product("Библия C#", 736);
            product.NameChanged += OnProductNameChanged;
            product.PriceChanged += OnProductPriceChanged;

            /*
             * TODO #7 Выполнить с экземпляром класса Product действия, 
             * приводящие к возникновению описанных Вами событий
             */
            product.Name = "Философия Java";
            product.Price = 1499;
            
        }

        /* 
         * TODO #8 Добавить определение обработчиков событий 
         */
        private static void OnProductNameChanged(object sender, ProductEventArgs e)
        {
            Console.WriteLine("Имя продукта было изменено с '{0}' на '{1}'", e.OldName, e.Product.Name);
        }
        private static void OnProductPriceChanged(object sender, ProductEventArgs e)
        {
            Console.WriteLine("Цена продукта была изменена с '{0}' на '{1}'", e.OldName, e.Product.Price);
        }
    }
}
    }
}
