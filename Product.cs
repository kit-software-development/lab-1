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
                /* 
                 * TODO #4 Инициировать уведомление об 
                 * изменении наименования
                 */
                var args = new NameChangeEventArgs(name, value);
                name = value;
                if (NameChanged != null)
                {
                    NameChanged(this, args);
                }
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
                /*
                 * TODO #5 Инициировать уведомление об 
                 * изменении стоимости
                 */
                var args = new PriceChangeEventArgs(price, value);
                price = value;
                if (PriceChanged != null)
                {
                    PriceChanged(this, args);
                }
            }
        }

        #endregion

        #region Events

        /* 
         * TODO #3 Добавить определение событий
         */
        public event EventHandler<NameChangeEventArgs> NameChanged;
        public event EventHandler<PriceChangeEventArgs> PriceChanged;

        #endregion

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
