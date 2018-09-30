using System;

namespace lesson2._1
{
	class Program
	{
		static void Main(string[] args)
		{
			var Cnv = new Converter(28, 30, 0.45);
			Console.WriteLine(Cnv.ConvertCurrencyToGrivna(Converter.Currensy.Eur, 10));
			Console.WriteLine(Cnv.ConvertGrivnaToCurrency(Converter.Currensy.Rub, 100));
			Console.ReadKey();
			
		}
	}
}
