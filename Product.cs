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
                var args = new NameChangeEventArgs(name, value);
               name = value;
                /* 
                 * TODO #4 Инициировать уведомление об 
                 * изменении наименования
                 */
                 if (NameChangeEvent != null)
                {
                    NameChangeEvent(this, args);
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
                var args = new PriceChangeEventArgs(price, value);
                price = value;
                /*
                 * TODO #5 Инициировать уведомление об 
                 * изменении стоимости
                 */
                 if (PriceChangeEvent != null)
                {
                    PriceChangeEvent(this, args); 
                }

            }
        }

        #endregion

        #region Events

        /* 
         * TODO #3 Добавить определение событий
         */

            // объявляем делегат
        public delegate void ProductHandler(object sender, EventArgs e);
            // событие, возникающие при изменении наименования
        public event EventHandler<NameChangeEventArgs> NameChangeEvent;
            // событие, возникающие при изменении стоимости
        public event EventHandler<ProductEventArgs> PriceChangeEvent;

        class NameChangeEventArgs : EventArgs
        { 
            public string Old { get; }
            public string Current { get; }

            public NameChangeEventArgs( string old, string current)
            {
                Old = old;
                Current = current;
            }
        }

        class PriceChangeEventArgs : EventArgs
        {
            public decimal Old { get; }
            public decimal Current { get; }

            public PriceChangeEventArgs(decimal old, decimal current)
            {
                Old = old;
                Current = current;
            }
        }



        #endregion

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
