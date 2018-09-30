using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3._3
{
	class Ship : Vehicle
	{
		public Ship(string price, string speed, string year, string passagers, string port) : base(price, speed, year)
		{
			Passagers = passagers;
			Port = port;
		}

		public string Passagers { get; }
		public string Port { get; }
	}
}
