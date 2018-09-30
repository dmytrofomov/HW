using System;

namespace lesson2._3
{
	class Program
	{
		static void Main(string[] args)
		{
			var inv = new Invoice("Name");
			Console.WriteLine(inv.GetPriseWithNds("1", 10));
			Console.WriteLine(inv.GetPriseWithoutNds("2", 10));
			Console.ReadKey();
		}
	}
}
