using System;

namespace _7._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			var trainSchedule = new WorkWithTrains();
			trainSchedule.AddTrains();
			trainSchedule.ShowTrainInfo(2);
		}
	}
}
