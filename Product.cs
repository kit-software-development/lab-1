using System;
using System.Security.Policy;

namespace Events
{
    class Product
    {
        #region Variables

        private string name;
        private decimal price;

        #endregion

        #region Properties

        public string Name
        {
            get { return name; }
            set
            {
                var args = new ProductEventArgs<string>(name,value);
                name = value;
                if (NameChanged != null)
                {
                    NameChanged(this, args);
                }
            }
               
        }
        
        public decimal Price
        {
            get { return price; }
            set
            {
                var args = new ProductEventArgs<decimal>(price,value);
                price = value;
                if (PriceChanged != null)
                {
                    PriceChanged(this, args);
                }
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
