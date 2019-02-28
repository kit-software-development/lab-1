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
        /* 
         * TODO #2 Добавить определение необходимых компонент 
         * класса ProductEventArgs
         */
        public string OldName { get; }
        public decimal OldPrice { get; }

        public ProductEventArgs(string oldName)
        {
            this.OldName = oldName;
        }

        public ProductEventArgs(decimal oldPrice)
        {
            this.OldPrice = oldPrice;
        }
    }
}
