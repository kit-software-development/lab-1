sing System;

namespace Events
{
    /// <summary>
    /// Класс, который служит для передачи аргументов 
    /// в обработчик событий, возникающих в классе 
    /// <seealso cref="Product">Product</seealso>
    /// </summary>
    
    class ProductChangedEventArgs<T> : EventArgs
    {
        public T OldValue { get; internal set; }

        public T NewValue { get; internal set; }

        public ProductChangedEventArgs(T oldValue, T newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}

