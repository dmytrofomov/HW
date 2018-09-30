using System;

namespace _6._1
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Используя Visual Studio, создайте проект по шаблону Console Application.
			//Требуется: Создать статический класс "IntArrayHelper" в котором реализовать методы:
			// 1.для заполнения всех элементов массива заданным значением
			// static void Fill(int[] array, int value).
			// 2.для заполнения всех элементов массива последовательными значениями(1, 2, 3, 4, 5, ...)
			// static void SequenceFill(int[] array)
			// 3.для вывода всех элементов массива на консоль
			// static void Print(int[] array)
			int[] array = new int[10];
			IntArrayHelper.SequenceFill(array);
			IntArrayHelper.Print(array);
			Console.Read();

		}
	}
}
