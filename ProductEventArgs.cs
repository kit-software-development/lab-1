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
    class ProductEventArgs
    {
        /* 
         * TODO #2 Добавить определение необходимых компонент 
         * класса ProductEventArgs
         */
        public string OldValue { get; }
        public string NewValue { get; }
        public ProductEventArgs (string oldvalue, string newvalue)
        {
            OldValue = oldvalue;
            NewValue = newvalue;
        }
    }
    class ProductEventArgsD
    {
        /* 
         * TODO #2 Добавить определение необходимых компонент 
         * класса ProductEventArgs
         */
        public decimal OldValue { get; }
        public decimal NewValue { get; }
        public ProductEventArgsD(decimal oldvalue, decimal newvalue)
        {
            OldValue = oldvalue;
            NewValue = newvalue;
        }
    }
}
