using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                var args = new ProductEventArgs<string>(name, value);
                name = value;
                if(NameChanged != null)
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
                var args = new ProductEventArgs<decimal>(name, value);
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

        public event EventHandler<ProductEventArgs<string>> NameChanged;
        public event EventHandler<ProductEventArgs<decimal>> PriceChanged;
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