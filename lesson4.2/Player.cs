using System;
using System.Collections.Generic;
using System.Text;

namespace lesson4._2
{
	class Player : IPlayable, IRecodable
	{
		void IPlayable.Pause()
		{
			Console.WriteLine("Pause play");
		}
		void IRecodable.Pause()
		{
			Console.WriteLine("Pause record");
		}

		public void Play()
		{
			Console.WriteLine("Play");
		}

		public void Record()
		{
			Console.WriteLine("Record");
		}

		 void IPlayable.Stop()
		{
			Console.WriteLine("Stop play");
		}

		 void IRecodable.Stop()
		{
			Console.WriteLine("Stop record");
		}
	}
}
