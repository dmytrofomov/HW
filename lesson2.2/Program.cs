using System;

namespace lesson2._2
{
	class Program
	{
		static void Main(string[] args)
		{
			var emp = new Employee("Dima", "Fomov")
			{
				Profession = "notManager",
				dateStartWork = new DateTime(2012, 02, 03)
			};
			emp.GetSallaryAndTax();
			Console.ReadKey();
			
		}
	}
}
