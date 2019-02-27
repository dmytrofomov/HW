using System;
using System.Collections.Generic;
using System.Text;

namespace lesson4._1
{
	public class XMLHandler : AbstractHandler
    {
        public override string CheckDocument()
        {
            return typeof(TXTHandler).Name;
        }

        public override void Chenge()
        {
            Console.WriteLine("Change XML");
        }

        public override void Create()
        {
            Console.WriteLine("Create XML");
        }

        public override void Open()
        {
            Console.WriteLine("Open XML");
        }

        public override void Save()
        {
            Console.WriteLine("Save XML");
        }
    }
}
