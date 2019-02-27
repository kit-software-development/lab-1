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

        public ProductEventArgs(decimal oldPrice)
        {
            OldPrice = oldPrice;
        }

        public ProductEventArgs(string oldName)
        {
            OldName = oldName;
        }

        /// <summary>
        ///     Стоимость до события
        /// </summary>
        public decimal OldPrice { get; private set; }

        /// <summary>
        ///     Имя до события
        /// </summary>
        public string OldName { get; private set; }
    }
}
