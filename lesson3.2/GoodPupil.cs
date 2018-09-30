using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3._2
{
	class GoodPupil : Pupil
	{
		public override void Study()
		{
			Console.WriteLine("Good study");
		}

		public override void Read()
		{
			Console.WriteLine("Good ");
		}
		public override void Write()
		{
			Console.WriteLine("Good ");
		}
		public override void Relax()
		{
			Console.WriteLine("Good Relax");
		}
	}
}
