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
                if(NameChange !=null)
                {
                    var args = new ProductEventArgs { OldName = name, NewName = value, OldPrice = price, ChangeDate = DateTime.Today };
                    NameChange(this, args);
                }

                name = value;
                

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
                if (PriceChange != null)
                {
                    var args = new ProductEventArgs { NewName = name, OldPrice = price, NewPrice = value, ChangeDate = DateTime.Today };
                    PriceChange(this, args);
                }

                price = value;
            }
        }

        #endregion

        #region Events

        public event EventHandler<ProductEventArgs> NameChange;
        public event EventHandler<ProductEventArgs> PriceChange;

        #endregion

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}