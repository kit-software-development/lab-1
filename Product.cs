using System;

namespace Events
{

    /// Класс должен описывать представление о товаре. 
    /// В рамках лабораторной работы должен являться 
    /// источником события
    
    class Product
    {

        #region Variables
        
        // Private variables
        private string _name;
        private decimal _price;

        #endregion

        #region Properties

        // Public variables
        public string name
        {
            get { return _name; }
            set
            {
                var eventArgs = new ProductEventArgs<string>(_name, value);
                _name = value;

                if (nameChanged != null)
                {
                    nameChanged(this, eventArgs);
                }
            }
        }
  
        public decimal price
        {
            get { return _price; }
            set
            {
                var eventArgs = new ProductEventArgs<decimal>(_price, value);
                _price = value;
                
                if (priceChanged != null)
                {
                    priceChanged(this, eventArgs);
                }
            }
        }

        #endregion

        #region Events

        // Public events
        public event EventHandler<ProductEventArgs<string>> nameChanged;
        public event EventHandler<ProductEventArgs<decimal>> priceChanged;

        #endregion

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

    }
}
