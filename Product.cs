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
                var args = new ProductEventArgs(name);
                name = value;

                if (event_NameChange != null)
                    event_NameChange.Invoke(this, args);
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
                var args = new ProductEventArgs(price);
                price = value;
                /*
                 * TODO #5 Инициировать уведомление об 
                 * изменении стоимости
                 */
                if (event_PriceChange != null)
                    event_PriceChange.Invoke(this, args);
            }
        }

        #endregion

        #region Events

        /* 
         * TODO #3 Добавить определение событий
         */

        public static EventHandler<ProductEventArgs> event_NameChange;
        public static EventHandler<ProductEventArgs> event_PriceChange;

        #endregion

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
