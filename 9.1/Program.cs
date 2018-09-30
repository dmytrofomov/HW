using System;

namespace _9._1
{
	public delegate int MyDelegate(int a, int b, int c);
	public delegate int MyDelegate2();
	class Program
	{
		static void Main(string[] args)
		{
			//Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и
			//возвращает среднее арифметическое этих аргументов.

			MyDelegate md = delegate (int a, int b, int c)
			{
				return (a + b + c) / 3;
			};
			Console.WriteLine(md(3,4,5));
			Console.Read();

			MyDelegate md2 = new MyDelegate(Delegat.Method1);

			
		}
	}

	public static class Delegat
	{
		public static int Method1(int a, int b, int c)
		{
			return 5;
		}
	}
}
