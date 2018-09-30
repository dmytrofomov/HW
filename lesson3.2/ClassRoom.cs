using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3._2
{
	class ClassRoom
	{
		private Pupil[] Pupils;
		public ClassRoom(params Pupil[] pupils)
		{
			Pupils = new Pupil[4];
			if(pupils.Length > 4)
			{
				Console.WriteLine("Only first 4 pupils in the line will be puted in this class");
			}
			
			for (int i = 0; i < 4; i++)
			{
				Pupils[i] = pupils[i];
			}
		}

		public void ShowAllPupilsInClass()
		{
			foreach (var item in Pupils)
			{
				item.Study();
			}
		}
	}
}
