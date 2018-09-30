using System;
using System.Collections.Generic;
using System.Text;

namespace _8._2
{
	class ColorConsole
	{
		public void Print(string stroka, int colorNumber)
		{
			switch (colorNumber)
			{
				case 0:
					Console.ForegroundColor = ConsoleColor.Blue;
					break;
				case 1:
					Console.ForegroundColor = ConsoleColor.Red;
					break;
				case 2:
					Console.ForegroundColor = ConsoleColor.Green;
					break;
				case 3:
					Console.ForegroundColor = ConsoleColor.Cyan;
					break;
				case 4:
					Console.ForegroundColor = ConsoleColor.Gray;
					break;
				default:
					Console.WriteLine("Wrong collor");
					break;
			}
			Console.WriteLine(stroka);
		}
	}

	public enum Colors
	{
		Blue,
		Red, 
		Green,
		Cyan,
		Gray
	}
}
