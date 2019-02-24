using System;

namespace Events
{
    
    /// Класс, который служит для передачи аргументов 
    /// в обработчик событий, возникающих в классе 
    
    class ProductEventArgs<T> : EventArgs 
    {
        public T oldValue { get; }
        public T newValue { get; }
        
        public ProductEventArgs(T oldValue, T newValue)
        {
            this.oldValue = oldValue;
            this.newValue = newValue;
        }
    }
}
