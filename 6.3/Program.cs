using System;
using System.Linq;

namespace _6._3
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Используя Visual Studio, создайте проект по шаблону Console Application.
			//Требуется: создать расширяющий метод для целочисленного массива, который сортирует элементы
			//массива по возрастанию.

			int[] array = new int[]{9,7,3,42,4,51,34,6,5,32,23,1 };
			var newArray = array.Ex();
			for (int i = 0; i < newArray.Length; i++)
			{
				Console.WriteLine(newArray[i]);
			}
			Console.Read();

		}
	}

	public static class Extention
	{
		public static int[] Ex(this int[] array) {

			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j] > array[i])
					{
						var temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}
			}
			return array ;
		}
	}
}
