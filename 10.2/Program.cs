using System;

namespace _10._2
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Используя Visual Studio, создайте проект по шаблону Console Application.
			//Создайте класс MyList<T>.Реализуйте в простейшем приближении возможность использования его
			//экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс
			//взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для
			//получения значения элемента по указанному индексу и свойство только для чтения для получения
			//общего количества элементов.

			//			Используя Visual Studio, создайте проект по шаблону Console Application.
			//Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
			//Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2
			//для данного урока.Выведите на экран значения элементов массива, который вернул расширяющий
			//метод GetArray().


			var a = new MyList<int>();
			a.Add(1);
			a.Add(2);
			a.Add(3);
			Console.WriteLine(a.ToString());
			Console.WriteLine(a[2]);
			a[2] = 10;
			Console.WriteLine(a[2]);
			Console.WriteLine("length = " + a.Length);
			int[] array = a.GetArray<int>();
			Console.Read();
		}
	}

	public class MyList<T> 
	{
		private T[] array;
		public int Length
		{
			get
			{
				return array.Length;
			}
		}

		public T this[int indexer]
		{
			get
			{
				if (indexer < array.Length)
				{
					return array[indexer];
				}
				throw new IndexOutOfRangeException();
			}
			set
			{
				if (indexer < array.Length)
				{
					array[indexer] = value;
				}
				else
				{
					throw new IndexOutOfRangeException();
				}
			}
		}
		public void Add(T element)
		{
			int currenLength = array?.Length ?? 0;
			var newArray = new T[currenLength + 1];
			for (int i = 0; i < currenLength; i++)
			{
				newArray[i] = array[i];
			}
			newArray[currenLength] = element;
			array = newArray;
		}

		public override string ToString()
		{
			var @string = "";
			for (int i = 0; i < (array?.Length ?? 0); i++)
			{
				@string += array[i] + ", ";
			}
			return @string;
		}
	}

	public static class Extention
	{
		public static T[] GetArray<T>(this MyList<T> list)
		{
			var array = new T[list.Length];
			for (int i = 0; i < list.Length; i++)
			{
				array[i] = list[i];
			}
			return array;
		}
	}
}
