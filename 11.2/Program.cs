using System;
using System.Collections;

namespace _11._2
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Используя Visual Studio, создайте проект по шаблону Console Application.
			//Создайте класс CarCollection<T>.Реализуйте в простейшем приближении возможность
			//использования его экземпляра для создания парка машин. Минимально требуемый интерфейс
			//взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и года
			//ее выпуска, индексатор для получения значения элемента по указанному индексу и свойство только для
			//чтения для получения общего количества элементов.
			//Создайте метод удаления всех машин автопарка
			var carCol = new CarCollection<Car>();
			carCol.AddCar(new Car("Porshe", 2018));
			carCol.AddCar(new Audi(2016));
			//carCol.AddCar("string");
			Console.WriteLine(carCol[0].Title);
			Console.WriteLine(carCol[1].Title);
			Console.Read();

		}
	}
	class CarCollection<T> where T : Car
	{
		public ArrayList arrayList { get; } = new ArrayList();
		public int Length { get; }

		public void AddCar(T car)
		{
			arrayList.Add(car);
		}

		public T this[int indexer]
		{
			get
			{
				if (indexer < arrayList.Count)
				{
					return arrayList[indexer] as T;
				}
				throw new IndexOutOfRangeException();
			}
			set
			{
				if (indexer < arrayList.Count)
				{
					arrayList[indexer] = value;
				}
				else
				{
					throw new IndexOutOfRangeException();
				}
			}
		}
	}

	public class Car
	{
		public Car(string title, int year)
		{
			Title = title;
			YearofCreate = year;
		}
		public string Title;
		public int YearofCreate;
	}

	public class Audi : Car
	{
		public Audi(int year) : base("Audi", year)
		{
		}
	}
}
