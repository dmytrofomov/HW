using System;
using System.Collections.Generic;
using System.Text;

namespace lesson2._1
{
	class Converter
	{
		private readonly double CourseUsd;
		private readonly double CourseEur;
		private readonly double CourseRub;

		public Converter(double usd, double eur, double rub)
		{
			CourseUsd = usd;
			CourseEur = eur;
			CourseRub = rub;
		}

		public double ConvertCurrencyToGrivna(Currensy convertFrom, double currencyAmount)
		{
			switch (convertFrom)
			{
				case Currensy.Rub:
					return currencyAmount * CourseRub;
				case Currensy.Eur:
					return currencyAmount * CourseEur;
				case Currensy.Usd:
					return currencyAmount * CourseUsd;
				default:
					Console.WriteLine("Unexpected error");
					return 0;
			}
		}

		public double ConvertGrivnaToCurrency(Currensy ToConvert, double grivaAmount)
		{
			switch (ToConvert)
			{
				case Currensy.Rub:
					return grivaAmount / CourseRub;
				case Currensy.Eur:
					return grivaAmount / CourseEur;
				case Currensy.Usd:
					return grivaAmount / CourseUsd;
				default:
					Console.WriteLine("Unexpected error");
					return 0;
			}
		}

		public enum Currensy 
		{
			Rub,
			Eur,
			Usd
		}
	}
}
