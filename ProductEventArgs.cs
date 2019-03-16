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
    public class EventArgs
    {
        public static readonly EventArgs Empty = new EventArgs();
        public EventArgs() { }
    }


    class ProductEventArgs : EventArgs
    {

        public string oldName { get; }
        public decimal oldPrice { get; }
        /* 
         * TODO #2 Добавить определение необходимых компонент 
         * класса ProductEventArgs
         */

        public ProductEventArgs(string oldName)
        {
            this.oldName = oldName;
        }

        public ProductEventArgs(decimal oldPrice)
        {
            this.oldName = oldPrice;

        }
    }
}
