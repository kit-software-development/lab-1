using System;

namespace Events
{
  class Program
  {
    internal Product Product
    {
      get
      {
        throw new System.NotImplementedException();
      }

      set
      {
        throw new System.NotImplementedException();
      }
    }

    static void Main(string[] args)
    {
      Product product = new Product("Some product name", 0);
      product.NameChanged += OnNameChange; 
      product.PriceChanged += OnPriceChange;
        /*TODO К событию прибавляем делегат*/
      product.Price = 11;
      product.Name = "Some another name";

    }

    private static void OnPriceChange(object sender, ProductEventArgs<decimal> e)
    {
      //Product product = sender as Product; 
      Console.WriteLine("Товар '{0}' сменил цену с {1} на {2}",((Events.Product) sender).Name , e.OldValue, e.NewValue);   
    }

    private static void OnNameChange(object sender, ProductEventArgs<string> e)
    {
      Console.WriteLine("Товар '{0}' сменил имя на '{1}'", e.OldValue, e.NewValue);
    }
  }
}
