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
        public string NewName { get; }

        public decimal OldPrice { get; }
        public decimal NewPrice { get; }

        public ProductEventArgs(string oldName, string newName)
        {
            OldName = oldName;
            NewName = newName;
        }

        public ProductEventArgs(decimal oldPrice, decimal newPrice)
        {
            OldPrice = oldPrice;
            NewPrice = newPrice;
        }

    }
}
