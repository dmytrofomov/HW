using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3._3
{
	class Plane : Vehicle
	{
		public Plane(string price, string speed, string year, string high, string passagers) : base(price, speed, year)
		{
			High = high;
			Passagers = passagers;
		}

		public string High { get; }
		public string Passagers { get; }
	}
}
