using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class ProductEventArgs<T>: EventArgs
    {
        private string name;
        private decimal value;

        /* 
* TODO #2 Добавить определение необходимых компонент 
* класса ProductEventArgs
*/
        public T OldValue { get; }
         public T NewValue { get; }

        public ProductEventArgs(T oldValue, T newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public ProductEventArgs(string name, decimal value)
        {
            this.name = name;
            this.value = value;
        }
    }
}