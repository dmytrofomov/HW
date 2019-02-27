using System;

namespace lesson4._1
{
	class Program
	{
		static void Main(string[] args)
		{
            var h = new TXTHandler();
            AbstractHandler ab = h;
            ShowDocType(ab);
            ab.Save();
        }

        static void ShowDocType(AbstractHandler doc)
        {
            Console.WriteLine(doc.CheckDocument());
        }
	}
}
