using System;

namespace Events
{
    /// <summary>
    /// Класс, который служит для передачи аргументов 
    /// в обработчик событий, возникающих в классе 
    /// <seealso cref="Product">Product</seealso>
    /// </summary>
    class ProductEventArgs : EventArgs
    {
        public string Old_Name { get; }
        public decimal Old_Price { get; }
        public string New_Name { get; }
        public decimal New_Price { get; }

        public ProductEventArgs(string old_Name, string new_Name, decimal old_Price, decimal new_Price)
        {
            /* 
             * определение необходимых компонент 
             * класса ProductEventArgs
             */
            Old_Name = old_Name;
            New_Name = new_Name;
            Old_Price = old_Price;
            New_Price = new_Price; 
        }
    }
}
