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
                ProductEventArgs arg = new ProductEventArgs(name);
                name = value;
                /* 
                 * TODO #4 Инициировать уведомление об 
                 * изменении наименования
                 */
                if (nameChanged != null)
                {
                    nameChanged(this, arg);
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
                ProductEventArgs arg = new ProductEventArgs(price);
                price = value;
                /*
                 * TODO #5 Инициировать уведомление об 
                 * изменении стоимости
                 */
                if (priceChanged != null)
                {
                    priceChanged(this, arg);
                }
            }
        }

        #endregion

        #region Events

        /* 
         * TODO #3 Добавить определение событий
         */
        public event EventHandler<ProductEventArgs> nameChanged;
        public event EventHandler<ProductEventArgs> priceChanged;

        #endregion

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
