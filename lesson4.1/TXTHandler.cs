using System;
using System.Collections.Generic;
using System.Text;

namespace lesson4._1
{
	class TXTHandler : AbstractHandler
    {
        public override string CheckDocument()
        {
            return typeof(TXTHandler).Name;
        }

        public override void Chenge()
        {
            Console.WriteLine("Change TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXT");
        }

        public override void Open()
        {
            Console.WriteLine("Open TXT");
        }

        public override void Save()
		{
			Console.WriteLine("Save TXT");
		}
	}
}
