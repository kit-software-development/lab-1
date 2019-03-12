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
                var args = new ProductChangedEventArgs<string>(name, value);
                name = value;
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
                var args = new ProductChangedEventArgs<decimal>(price, value);
                price = value;
                PriceChanged?.Invoke(this, args);
            }
        }

        #endregion

        #region Events

        public event EventHandler<ProductChangedEventArgs<string>> NameChanged;

        public event EventHandler<ProductChangedEventArgs<decimal>> PriceChanged;

        #endregion

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}


