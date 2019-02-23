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
                string old_name = name;
                name = value;
                /* 
                 * TODO #4 Инициировать уведомление об 
                 * изменении наименования
                 */
                NameChangeHandler?.Invoke(this, new ProductEventArgs(old_name));
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
                decimal old_price = price;
                price = value;
                /*
                 * TODO #5 Инициировать уведомление об 
                 * изменении стоимости
                 */
                PriceChangeHandler?.Invoke(this, new ProductEventArgs(old_price));
            }
        }

        #endregion

        #region Events

        /* 
         * TODO #3 Добавить определение событий
         */
        public static event EventHandler<ProductEventArgs> NameChangeHandler;
        public static event EventHandler<ProductEventArgs> PriceChangeHandler;

        #endregion

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
