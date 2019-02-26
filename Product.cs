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

        public delegate void ChangeName(object sender, ProductEventArgs arg);
        public delegate void ChangePrice(object sender, ProductEventArgsD arg);
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
                var args = new ProductEventArgs(name, value);
                name = value;
                if (ProductNameChange != null)
                {
                    ProductNameChange(this, args);
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
                var args = new ProductEventArgsD(price, value);
                price = value;
                if (ProductPriceChange != null)
                {
                    ProductPriceChange(this, args);
                }
            }
        }

        #endregion

        #region Events

        /* 
         * TODO #3 Добавить определение событий
         */
        public event ChangeName ProductNameChange;
        public event ChangePrice ProductPriceChange;

        #endregion

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
