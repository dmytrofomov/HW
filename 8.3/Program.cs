using System;

namespace _8._3
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Используя Visual Studio, создайте проект по шаблону Console Application.
			//Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
			//Присвойте каждой константе значение, задающее количество часов, которые должен отработать
			//сотрудник за месяц.
			//Создайте класс Accountant с методом bool AskForBonus(Post worker, int hours), отражающее
			//давать или нет сотруднику премию. Если сотрудник отработал больше положенных часов в месяц, то ему
			//положена премия.
			Console.WriteLine(new Accountant().AskForBonus(Post.Director, 300));
			Console.Read();
			
		}
	}

	public class Accountant
	{
		public bool AskForBonus(Post worker, int hours)
		{
			if ((int) worker < hours)
			{
				return true;
			}
			return false;
		}
	}

	public enum Post
	{
		Loh = 10,
		Manager = 100,
		Director = 300,
		SuperDirector = 1000
	}
}
