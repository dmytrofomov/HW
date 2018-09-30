using System;
using System.Collections.Generic;
using System.Text;

namespace _6._2
{
	internal class Building
	{
		internal readonly Apartment[] Apartments;

		internal Building(Apartment[] apartments)
		{
			Apartments = apartments;
		}
		internal class Apartment
		{
			internal string Number { get; set; }
			internal bool IsFree { get; set; }

		}
	}
}
