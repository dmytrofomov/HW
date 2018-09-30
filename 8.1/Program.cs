using System;

namespace _8._1
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить
			//количество дней до его следующего дня рождения.
			NextBirthday nb = new NextBirthday("1999.01.09");
			nb.When();
			Console.Read();
		}

		
	}
	class NextBirthday
	{
		TimeSpan TotalDays;
		DateTime currentDate = DateTime.Now;
		DateTime annualBirthday;


		public NextBirthday(string date)
		{
			DateTime.TryParse(date, out var dateOfBirthday);
			annualBirthday = new DateTime(currentDate.Year, dateOfBirthday.Month, dateOfBirthday.Day);

		}
		public void When()
		{
		
				if (currentDate < annualBirthday)
				{
					TotalDays = annualBirthday - currentDate;
					Console.WriteLine("Your birthday will be in " + (int)TotalDays.TotalDays + " days");
				}
				else
				{
				TimeSpan oneYear = new TimeSpan(365,0,0,0);
				TotalDays = annualBirthday - currentDate + oneYear;
				Console.WriteLine("Your birthday will be in " + (int)TotalDays.TotalDays + " days");
				}
			
			
		}
	}
}
