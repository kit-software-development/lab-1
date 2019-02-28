using System;

namespace Events
{
	/// <summary>
	///     Класс, который служит для передачи аргументов
	///     в обработчик событий, возникающих в классе
	///     <seealso cref="Product">Product</seealso>
	/// </summary>
	internal class ProductEventArgs : EventArgs
	{
		public readonly String  OldName;
		public readonly String  NewName;
		public readonly Decimal OldPrice;
		public readonly Decimal NewPrice;

		public ProductEventArgs(String oldName, String newName, Decimal oldPrice, Decimal newPrice)
		{
			OldName  = oldName;
			NewName  = newName;
			OldPrice = oldPrice;
			NewPrice = newPrice;
		}

		/// <summary>
		///     Определяет, изменилось ли имя продукта.
		/// </summary>
		public Boolean NameChanged => OldName != NewName;

		/// <summary>
		///     Определяет, изменилась ли цена продукта.
		/// </summary>
		public Boolean PriceChanged => OldPrice != NewPrice;

		public override String ToString()
		{
			String nameDiff  = NameChanged ? $"{OldName} -> {NewName}" : "unchanged";
			String priceDiff = PriceChanged ? $"{OldPrice} -> {NewPrice}" : "unchanged";

			return $"Name: {nameDiff}, Price: {priceDiff}";
		}
	}
}