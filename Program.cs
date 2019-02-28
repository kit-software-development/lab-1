using System;

namespace Events
{
	internal static class Program
	{
		private static void Main(String[] args)
		{
			Product product = new Product("Some product name", 0);

			product.NameChanged  += ProductOnNameChanged;
			product.PriceChanged += ProductOnPriceChanged;

			Console.WriteLine("Changing name");
			product.Name = "Iron plates";

			Console.WriteLine("Changing price");
			product.Price = 42;
		}

		private static void ProductOnPriceChanged(Object sender, ProductEventArgs e)
		{
			Console.WriteLine(e);
		}

		private static void ProductOnNameChanged(Object sender, ProductEventArgs e)
		{
			Console.WriteLine(e);
		}
	}
}