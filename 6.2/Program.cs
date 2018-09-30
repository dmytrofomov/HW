using System;
using System.Linq;

namespace _6._2
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Используя Visual Studio, создайте проект по шаблону Console Application.
			//Требуется: Создать класс "Building".Создать класс "Apartment" вложений в "Building".
			//Класс "Building" должен иметь свойство только для чтения "Apartments" – массив из "Apartment"
			// Каждый экземпляр класса "Apartment" имеет свойство "Number" – номер квартиры, и свойство
			//"IsFree" – логическое значение.
			// Создать экземпляр "Building", указать какие квартиры в доме будут занятие и вывести на консоль все
			//свободные квартиры.
			

			var apartments = new Building.Apartment[3]
				{
					new Building.Apartment
					{
						Number = "10",
						IsFree = true
					},
					new Building.Apartment
					{
						Number = "11",
						IsFree = true
					},
					new Building.Apartment
					{
						Number = "1",
						IsFree = false
					}
				};

			var building = new Building(apartments);

			var sortedAppartments = building.Apartments.Where(x => x.IsFree == true).ToList();

			sortedAppartments.ForEach(x => Console.WriteLine($"Free Appartments is {x.Number}"));

			Console.Read();
			
			
		}
	}
}
