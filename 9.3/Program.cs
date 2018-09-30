using System;

namespace _9._3
{
	public delegate int MainDelegete(ChildDelegete[] array);
	public delegate int ChildDelegete();

	class Program
	{
		static void Main(string[] args)
		{
			//	Используя Visual Studio, создайте проект по шаблону Console Application.
			//Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает
			//среднее арифметическое возвращаемых значений методов, сообщенных с делегатами в массиве.
			//Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.
			ChildDelegete[] arrayDelegate = new ChildDelegete[3]
			{	MyDelegates.LittleDelegate,
				MyDelegates.LittleDelegate,
				MyDelegates.LittleDelegate
			};
			MainDelegete main = delegate(ChildDelegete[] a) 
			{
				int middleNum = 0;
				for (int i = 0; i < arrayDelegate.Length; i++)
				{
					middleNum += arrayDelegate[i]();
				}
				return middleNum / arrayDelegate.Length;
			};
		}
	}

	public static class MyDelegates
	{
		public static int LittleDelegate()
		{
			Random rd = new Random();
			return rd.Next();
		}

		
	}
}
