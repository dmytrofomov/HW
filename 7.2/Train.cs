using System;
using System.Collections.Generic;
using System.Text;

namespace _7._2
{

	//	Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта
	//назначения, номер поезда, время отправления.
	//Написать программу, выполняющую следующие
	public struct Train
	{
		public string PointOfDestenation;
		public int TrainNumber;
		public string ArrivalTime;



	}

	public class WorkWithTrains
	{
		public Train[] Trains { get; set; }
		int CountOfTrains { get; set; }

		public void AddTrains()
		{
			do
			{
				Console.WriteLine("How mutch trains do you want add?");
				bool result = int.TryParse(Console.ReadLine(), out int countOfTrains);
				if (result)
				{
					CountOfTrains = countOfTrains;
					break;
				}
			} while (true);

			Trains = new Train[CountOfTrains];
			for (int i = 0; i < CountOfTrains; i++)
			{
				var train = new Train();
				Console.WriteLine("Enter train number");
				train.TrainNumber = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter point of destnation");
				train.PointOfDestenation = Console.ReadLine();
				Console.WriteLine("Enter arrival time");
				train.ArrivalTime = Console.ReadLine();
				Trains[i] = train;
			}
		}

		public void ShowTrainInfo(int trainNumber)
		{
			for (int i = 0; i < Trains.Length; i++)
			{
				if(Trains[i].TrainNumber == trainNumber)
				{
					Console.WriteLine("Train " + Trains[i].TrainNumber + "arrive " + Trains[i].ArrivalTime);
					break;
				}
			}
		}


	}
}

