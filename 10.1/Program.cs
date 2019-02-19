using System;

namespace _10._1
{
	class Program
	{
		static void Main(string[] args)
		{
			//			Используя Visual Studio, создайте проект по шаблону Console Application.
			//Создайте класс MyClass<T>, содержащий статический фабричный метод – T FacrotyMethod(),
			//который будет порождать экземпляры типа, указанного в качестве параметра типа(указателя места
			//заполнения типом – Т).
			//Factory<int>.instance = 10;
			Console.WriteLine(Factory<int>.FacrotyMethod());
			Console.Read();
		}
	}

	public static class Factory<T>
	{
		public static T instance { get; set; }
		public static T FacrotyMethod()
		{

			return instance;
		}
	}
}
