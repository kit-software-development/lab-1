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
    public class ProductEventArgs<T> : EventArgs
    {
        /* 
         * TODO #2 Добавить определение необходимых компонент 
         * класса ProductEventArgs
         */

        public T Oldvalue { get; }
        public T Newvalue { get; }

        public ProductEventArgs(T oldValue, T newValue)
        {
            Oldvalue = oldValue;
            Newvalue = newValue;
        }

    }
}