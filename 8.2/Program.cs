using System;

namespace _8._2
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Используя Visual Studio, создайте проект по шаблону Console Application.
			//Создайте статический класс с методом void Print(string stroka, int color), который выводит на
			//экран строку заданным цветом.Используя перечисление, создайте набор цветов, доступных
			//пользователю.Ввод строки и выбор цвета предоставьте пользователю.

			var ColorConsole = new ColorConsole();
			
			ColorConsole.Print("string", (int) Colors.Cyan);
			Console.Read();


		}
	}
}
