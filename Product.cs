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
                var args = new ProductEventArgs(name, value, price, price);
                name = value;
                /*TODO #4 Инициировать уведомление об изменении наименования*/
                NameChanged?.Invoke(this, args);
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
                var args = new ProductEventArgs(name, name, price, value);
                price = value;
                /*TODO #5 Инициировать уведомление об изменении стоимости*/
                PriceChanged?.Invoke(this, args);
            }
        }

        #endregion

        #region Events

        /*TODO #3 Добавить определение событий*/
        public event EventHandler<ProductEventArgs> NameChanged;
        public event EventHandler<ProductEventArgs> PriceChanged;

        #endregion

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
