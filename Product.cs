using System;

namespace Events
{
    /// <summary>
    /// Класс должен описывать представление о товаре. 
    /// В рамках лабораторной работы должен являться 
    /// источником события
    /// </summary>
    class Product
    {

        #region Variables
        /// <summary>
        /// Наименование
        /// </summary>
        private string name;
        /// <summary>
        /// Стоимость
        /// </summary>
        private decimal price;

        #endregion 

        #region Properties

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                var args = new ProductNameChangedEventArgs(name, value);
                name = value;
                if (NameChanged != null)
                {
                    NameChanged(this, args);
                }

                /* 
                 * TODO #4 Инициировать уведомление об 
                 * изменении наименования
                 */
            }
        }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set
            {
                var args = new ProductPriceChangedEventArgs(price, value);
                price = value;
                if (PriceChanged != null)
                {
                    PriceChanged(this, args);
                }
                /*
                 * TODO #5 Инициировать уведомление об 
                 * изменении стоимости
                 */
            }
        }

        #endregion 

        #region Events

        public event EventHandler<ProductNameChangedEventArgs> NameChanged;

        public event EventHandler<ProductPriceChangedEventArgs> PriceChanged;
        
        /* 
         * TODO #3 Добавить определение событий
         */

        #endregion 

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
