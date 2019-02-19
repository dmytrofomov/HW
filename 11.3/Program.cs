using System;

namespace _11._3
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Используя Visual Studio, создайте проект по шаблону Console Application.
			//Создайте класс ArrayList.Реализуйте в простейшем приближении возможность использования его
			//экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections.
			ArrayList a = new ArrayList();
			a.Add(1);
			a.Add("string");

			for (int i = 0; i < a.Length; i++)
			{
				Console.WriteLine(a[i]);
			}
			Console.Read();
		}
	}
	class ArrayList
	{
		object[] array;
		public int Length
		{
			get
			{
				return array.Length;
			}
		}
		public void Add(object element)
		{

			int currenLength = array?.Length ?? 0;
			var newArray = new object[currenLength + 1];
			for (int i = 0; i < currenLength; i++)
			{
				newArray[i] = array[i];
			}
			newArray[currenLength] = element as object;
			array = newArray;
		}

		public object this[int indexer]
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
	}
}
