using System;

namespace Home_Delegates
{
    /// <summary>
    /// Класс, который служит для передачи аргументов 
    /// в обработчик событий, возникающих в классе 
    /// <seealso cref="Product">Product</seealso>
    /// </summary>
    /*
     * TODO #1 Закончить определение класса ProductEventArgs
     */
    public class ProductChangedEventArgs<T> : EventArgs
    {
        /* 
         * TODO #2 Добавить определение необходимых компонент 
         * класса ProductEventArgs
         */
        /*public string Id { get; }*/
        public T OldValue { get; }
        public T NewValue { get; }

        public ProductChangedEventArgs(/*string id, */T oldValue, T newValue)
        {
            /*Id = id;*/
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}