using System;

namespace lesson3._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Pupil pupil1 = new ExcelentPupil();
			Pupil pupil2 = new GoodPupil();
			Pupil pupil3 = new BadPupil();
			Pupil pupil4 = new BadPupil();
			Pupil pupil5 = new BadPupil();

			ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4, pupil5);
			classRoom.ShowAllPupilsInClass();
			Console.ReadKey();
		}
	}
}
