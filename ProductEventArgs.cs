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
        public static readonly ProductEventArgs Empty = new ProductEventArgs();
        public ProductEventArgs() { }
    }
    class NameChangeEventArgs :  ProductEventArgs {
        /// <summary>
        ///     Имя до события.
        /// </summary>
        public string Old { get; }

        /// <summary>
        ///     Имя, после события.
        /// </summary>
        public string Current { get; }

        public NameChangeEventArgs(string old, string current)
        {
            Old = old;
            Current = current;
        }
    }
    class PriceChangeEventArgs: ProductEventArgs
    {
        public decimal Old { get; }

        /// <summary>
        ///     Имя, после события.
        /// </summary>
        public decimal Current { get; }

        public PriceChangeEventArgs(decimal old, decimal current)
        {
            Old = old;
            Current = current;
        }
    }
}
