using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3._2
{
	class ExcelentPupil : Pupil
	{
		public override void Study()
		{
			Console.WriteLine("Perfect study");
		}

		public override void Read()
		{
			Console.WriteLine("Pefect ");
		}
		public override void Write()
		{
			Console.WriteLine("Perfect ");
		}
		public override void Relax()
		{
			Console.WriteLine("Perfect Relax");
		}
	}
}
