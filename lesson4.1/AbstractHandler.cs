using System;
using System.Collections.Generic;
using System.Text;

namespace lesson4._1
{
	public abstract class AbstractHandler 
    {
        public abstract void Open();

        public abstract void Create();

        public abstract void Chenge();

		public abstract void Save();

        public abstract string CheckDocument();
    }
}
