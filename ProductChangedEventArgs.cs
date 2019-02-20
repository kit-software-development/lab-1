using System;

namespace Events
{
    /// <inheritdoc />
    /// <summary>
    /// Класс, который служит для передачи аргументов 
    /// в обработчик событий, возникающих в классе 
    /// <seealso cref="T:Events.Product">Product</seealso>
    /// </summary>
    public class ProductChangedEventArgs<T> : EventArgs
    {
        public T OldValue { get; }

        public T NewValue { get; }

        public ProductChangedEventArgs(T oldValue, T newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}