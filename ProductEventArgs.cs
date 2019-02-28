using System;

namespace Events
{
    /// <summary>
    /// Класс, который служит для передачи аргументов 
    /// в обработчик событий, возникающих в классе 
    /// <seealso cref="Product">Product</seealso>
    /// </summary>
    /*TODO #1 Закончить определение класса ProductEventArgs*/
    class ProductEventArgs : EventArgs
    {
        public string Prev_Name { get; }
        public string New_Name { get; }
        public decimal Prev_Price { get; }
        public decimal New_Price { get; }
        /* TODO #2 Добавить определение необходимых компонент класса ProductEventArgs*/
        public ProductEventArgs(string prev_Name, string new_Name, decimal prev_Price, decimal new_Price)
        {
            Prev_Name = prev_Name;
            New_Name = new_Name;
            Prev_Price = prev_Price;
            New_Price = new_Price;
        }
    }
}
