using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3._2
{
	class ClassRoom
	{
	    private Pupil[] Pupils { get; }

	    public ClassRoom(params Pupil[] pupils)
		{

			if(pupils.Length > 4)
			{
				Console.WriteLine("Only first 4 pupils in the line will be puted in this class");
                Pupils = new Pupil[4];
			    for (int i = 0; i < 4; i++)
			    {
			        Pupils[i] = pupils[i];
			    }
            }
			else
			{
			    Pupils = pupils;
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
