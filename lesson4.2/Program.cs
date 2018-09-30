using System;

namespace lesson4._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Player player = new Player();
			var recorder = player as IRecodable;
			var audioPlayer = recorder as IPlayable;
			recorder.Pause();
			audioPlayer.Pause();
			Console.Read();
		}
	}
}
