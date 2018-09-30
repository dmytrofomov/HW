using System;

namespace _5._1
{
	class Program
	{
		static void Main(string[] args)
		{
			var arraysClass = new Array();
			int[] array = arraysClass.GetArray();
			Console.WriteLine(arraysClass.GetArraySum(array));
			Console.WriteLine(arraysClass.GetMaxArrayValue(array));
			Console.WriteLine(arraysClass.MiddleArifmethic(array));
			Console.Read();
		}
	}
}
