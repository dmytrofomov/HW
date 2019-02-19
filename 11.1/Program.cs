using System;
using System.Collections;

namespace _11._1
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Используя Visual Studio, создайте проект по шаблону Console Application.
			//В коллекцию ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа,
			//переберите данную коллекцию с помощью, цикла for. С какой проблемой вы столкнулись ?

			ArrayList arrayList = new ArrayList();
			arrayList.Add(1);
			arrayList.Add("Two");
			arrayList.Add(new MyClass());
			for (int i = 0; i < arrayList.Count; i++) 
			{
				Console.WriteLine(arrayList[i]);
			}
			Console.Read();
			
		}
	}
	class MyClass
	{
		public int Title;
	}
}
