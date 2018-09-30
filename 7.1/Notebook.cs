using System;
using System.Collections.Generic;
using System.Text;

namespace _7._1
{
	struct Notebook
	{
		string Model;
		string Producer;
		int Price;

		public Notebook(string model, string producer, int price)
		{
			Model = model;
			Producer = producer;
			Price = price;
		}

		public void ShowInfo()
		{
			Console.WriteLine(Model + Producer + Price);
		}

	}
}
