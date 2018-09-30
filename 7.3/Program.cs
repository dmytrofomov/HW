using System;

namespace _7._3
{
	class Program
	{

//		Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры
//структуры и класса.Измените, значения полей экземпляров на «не изменено», а затем вызовите методы
//ClassTaker и StruktTaker.Выведите на экран значения полей экземпляров. Проанализируйте
//полученные результаты.

		static void Main(string[] args)
		{
			MyStruct st = new MyStruct();
			var cl = new MyClass();
			st.change = "not changed";
			cl.change = "not changed";

			StruktTaker(st);
			ClassTaker(cl);
			Console.WriteLine("Struct:" + st.change + "Class  " + cl.change);
			Console.Read();


		}

		static void ClassTaker(MyClass myClass)
		{
			myClass.change = "changed";
		}
		static void StruktTaker(MyStruct myClass)
		{
			myClass.change = "changed";
		}
	}
}
