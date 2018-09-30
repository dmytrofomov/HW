using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3._3
{
	class Vehicle
	{
		public string Price { get; }
		public string Speed { get; }
		public string Year { get; }

		public Vehicle(string price, string speed, string year)
		{
			Price = price;
			Speed = speed;
			Year = year;
		}
	}
}
