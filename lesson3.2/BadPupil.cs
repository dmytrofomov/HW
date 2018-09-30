using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3._2
{
	class BadPupil : Pupil
	{
		public override void Study()
		{
			Console.WriteLine("Bad study");
		}

		public override void Read()
		{
			Console.WriteLine("Bad ");
		}
		public override void Write()
		{
			Console.WriteLine("Bad ");
		}
		public override void Relax()
		{
			Console.WriteLine("Bad Relax");
		}
	}
}
