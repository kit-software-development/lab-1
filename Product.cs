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
                var args = new ProductEventArgs<string>(name, value);
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
                var args = new ProductEventArgs<decimal>(price, value);
                price = value;
                if (PriceChanged != null)
                {
                    PriceChanged(this, args);
                }
            }
        }

        #endregion

        #region Events
        public event EventHandler<ProductEventArgs<decimal>> PriceChanged;
        public event EventHandler<ProductEventArgs<string>> NameChanged;
        #endregion

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
