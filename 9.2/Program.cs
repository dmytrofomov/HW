using System;

namespace _9._2
{
	public delegate int MyDelegate(int x, int y);
	class Program
	{
		static void Main(string[] args)
		{
			//			Используя Visual Studio, создайте проект по шаблону Console Application.
			//Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub –
			//вычитание, Mul – умножение, Div – деление). Каждый лямбда оператор должен принимать два
			//аргумента и возвращать результат вычисления.Лямбда оператор деления должен делать проверку
			//деления на ноль.
			//Написать программу, которая будет выполнять арифметические действия, указанные пользователем
			MyDelegate add = (x, y) => { return x + y; };
			MyDelegate sub = (x, y) => { return x - y; };
			MyDelegate mul = (x, y) => { return x * y; };
			MyDelegate div = (x, y) => 
			{
				if (y != 0)
				{
					return x / y;
				}
				else
				{
					Console.WriteLine("cant divide by 0");
					return -1;
				}
			};

			Console.WriteLine(div(10, 2));
			Console.Read();
		}
	}
}
