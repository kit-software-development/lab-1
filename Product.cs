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
            get => name;
            set
            {
                NameChanged?.Invoke(this, new ProductEventArgs<string>(name, value));
                name = value;
            }
        }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price
        {
            get => price;
            set
            {
                PriceChanged?.Invoke(this, new ProductEventArgs<decimal>(price, value));
                price = value;
            }
        }

        #endregion

        #region Events

        public event EventHandler<ProductEventArgs<string>> NameChanged;

        public event EventHandler<ProductEventArgs<decimal>> PriceChanged;

        #endregion

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
