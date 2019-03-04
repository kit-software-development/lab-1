using System;

namespace Events
{
    public class ProductEventArgs<T> : EventArgs
    {
        public T OldValue { get;}
        public T NewValue { get;}

        public ProductEventArgs( T oldvalue, T newvalue)
        {
            OldValue = oldvalue;
            NewValue = newvalue;
        }
        
    }
}