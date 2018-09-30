using System;

namespace lesson3._4
{
	class Program
	{
		static void Main(string[] args)
		{
			DocumentWorker doc = new DocumentWorker();
			Console.WriteLine("Enter key, pres Enter to use basic version");
			var key = Console.ReadLine();
			if (key != "pro" || key != "exp")
			{
				Console.WriteLine("Wrong key, using basic version");
			}
			if (key == null)
			{
				 doc = new DocumentWorker();
			}
			if (key == "pro")
			{
				 doc = new ProDocumentWorker();
			}
			if (key == "exp")
			{
				 doc = new ExpertDocumentWorker();
			}
			doc.SaveDocument();
			Console.Read();
		}
	}
}
