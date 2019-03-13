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

        public string OldValueName { get; }
        public string NewValueName { get; }
        public ProductEventArgs(string oldvaluename, string newvaluename)
        {
            OldValueName = oldvaluename;
            NewValueName = newvaluename;
        }
        
        public decimal OldValuePrice { get; }
        public decimal NewValuePrice { get; }
        public ProductEventArgs(decimal oldvalueprice, decimal newvalueprice)
        {
            OldValuePrice = oldvalueprice;
            NewValuePrice = newvalueprice;
        }
        /**/
    }
}
