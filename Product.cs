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
        private string _name;
        /// <summary>
        /// Стоимость
        /// </summary>
        private decimal _price;

        #endregion

        #region Properties

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                var args = new ProductEventArgs(_name);
                _name = value;
                /* 
                 * TODO #4 Инициировать уведомление об изменении наименования
                 */
                if (EventNameChangeHandler != null) EventNameChangeHandler.Invoke(this, args);
            }
        }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price
        {
            get { return _price; }
            set
            {
                var args = new ProductEventArgs(_price);
                _price = value;
                /*
                 * TODO #5 Инициировать уведомление об 
                 * изменении стоимости
                 */
                if (EventPriceChangeHandler != null) EventPriceChangeHandler.Invoke(this, args);
            }
        }

        #endregion

        #region Events

        /* 
         * TODO #3 Добавить определение событий
         */
        public static event EventHandler<ProductEventArgs> EventNameChangeHandler;
        public static event EventHandler<ProductEventArgs> EventPriceChangeHandler;

        #endregion

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
