using System;

namespace Events
{
    /// <summary>
    /// Класс, который служит для передачи аргументов 
    /// в обработчик событий, возникающих в классе 
    /// <seealso cref="Product">Product</seealso>
    /// </summary>
    sealed class ProductEventArgs : EventArgs
    {
        public string OldName { get; internal set; }
        public string NewName { get; internal set; }
        public decimal OldPrice { get; internal set; }
        public decimal NewPrice { get; internal set; }
        public DateTime ChangeDate { get; internal set; }

    }
}