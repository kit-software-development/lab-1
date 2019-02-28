using System;
namespace Events
{
    /// <summary>
    /// Класс, который служит для передачи аргументов 
    /// в обработчик событий, возникающих в классе 
    /// <seealso cref="Product">Product</seealso>
    /// </summary>
    /*
     * TODO #1 Закончить определение класса ProductEventArgs
     */
    class ProductEventArgs : EventArgs
    {
        public string Name { get; }
        public decimal Price { get; }

        public ProductEventArgs(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        /* 
         * TODO #2 Добавить определение необходимых компонент 
         * класса ProductEventArgs
         */
    }

    class ProductNameChangedEventArgs : EventArgs
    {
        public string NewName { get; }
        public string OldName { get; }
        public ProductNameChangedEventArgs(string oldName, string newName)
        {
            OldName = oldName;
            NewName = newName;
        }
    }

    class ProductPriceChangedEventArgs : EventArgs
    {
        public decimal NewPrice { get; }
        public decimal OldPrice { get; }
        public ProductPriceChangedEventArgs(decimal oldPrice, decimal newPrice)
        {
            OldPrice = oldPrice;
            NewPrice = newPrice;
        }
    }
}
