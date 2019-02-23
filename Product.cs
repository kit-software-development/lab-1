using System;

namespace Events
{
    /// <summary>
    /// Класс должен описывать представление о товаре. 
    /// В рамках лабораторной работы должен являться 
    /// источником события
    /// </summary>
    public class Product
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
            get => _name;
            set
            {
                var args = new ProductChangedEventArgs<string>(_name, value);
                _name = value;
                NameChanged?.Invoke(this, args);
            }
        }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price
        {
            get => _price;
            set
            {
                var args = new ProductChangedEventArgs<decimal>(_price, value);
                _price = value;
                PriceChanged?.Invoke(this, args);
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// Событие об изменении наименования <seealso cref="Name"/>
        /// </summary>
        public event EventHandler<ProductChangedEventArgs<string>> NameChanged;

        /// <summary>
        /// Событие об изменении стоимости <seealso cref="Price"/>
        /// </summary>
        public event EventHandler<ProductChangedEventArgs<decimal>> PriceChanged;

        #endregion

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}