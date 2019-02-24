using System;

namespace Events
{
    /// <summary>
    /// Класс, который служит для передачи аргументов 
    /// в обработчик событий, возникающих в классе 
    /// <seealso cref="Product">Product</seealso>
    /// </summary>
    /// 
    class ProductEventArgs<T> : EventArgs
    {
        public T PropertyOldValue { get; }     

        public T PropertyNewValue { get; }

        public ProductEventArgs(T propertyOldValue, T propertyNewValue)
        {
            PropertyOldValue = propertyOldValue;
            PropertyNewValue = propertyNewValue;
        }
    }
}
