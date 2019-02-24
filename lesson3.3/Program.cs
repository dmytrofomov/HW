using System;
using System.Collections.Generic;

namespace lesson3._3
{
	class Program
	{
		static void Main(string[] args)
		{
            List<Vehicle> list = new List<Vehicle>
            {
                new Plane("1000000 $", "750", "1999", "3 M", "50"),
                new Car("10000 $", "200", "2009"),
                new Ship("100000 $", "150", "2009", "400", "Berdyansk")
            };

            foreach (var item in list)
		    {
		        Console.WriteLine($"Vehicle type - {item.GetType().Name} \n" +
		                          $"Speed {item.Speed} \n" +
		                          $"Year {item.Year}");

		        if (item is Ship ship)
		        {
		            Console.WriteLine($"Port {ship.Port}");
		        }

		        if (item as Plane != null)
		        {
		            Console.WriteLine($"Port {(item as Plane).Passagers}");
		        }
            }

        }
	}
}
