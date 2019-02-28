using System;

namespace Events
{
	/// <summary>
	///     Класс должен описывать представление о товаре.
	///     В рамках лабораторной работы должен являться
	///     источником события
	/// </summary>
	internal class Product
	{
		/// <summary>
		///     Наименование
		/// </summary>
		private String _name;

		/// <summary>
		///     Стоимость
		/// </summary>
		private Decimal _price;

		public Product(String name, Decimal price)
		{
			Name  = name;
			Price = price;
		}

		/// <summary>
		///     Возникает, когда имя продукта было изменено.
		/// </summary>
		public event EventHandler<ProductEventArgs> NameChanged;

		/// <summary>
		///     Возникает, когда цена продукта была изменена.
		/// </summary>
		public event EventHandler<ProductEventArgs> PriceChanged;

		/// <summary>
		///     Наименование
		/// </summary>
		public String Name
		{
			get => _name;
			set
			{
				if (_name == value)
					return;

				String oldName = _name;

				_name = value;
				NameChanged?.Invoke(this, new ProductEventArgs(oldName, _name, _price, _price));
			}
		}

		/// <summary>
		///     Стоимость
		/// </summary>
		public Decimal Price
		{
			get => _price;
			set
			{
				if (_price == value)
					return;

				Decimal oldPrice = _price;

				_price = value;
				PriceChanged?.Invoke(this, new ProductEventArgs(_name, _name, oldPrice, _price));
			}
		}
	}
}