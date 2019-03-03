using System;

namespace _5._1
{
	class Program
	{
		static void Main(string[] args)
		{
			var arraysClass = new ArrayHelper();
			int[] array = arraysClass.GetArray();
            //Console.WriteLine(arraysClass.GetArraySum(array));
            //Console.WriteLine(arraysClass.GetMaxArrayValue(array));
            //Console.WriteLine(arraysClass.MiddleArifmethic(array));

            int[] notOddarray = arraysClass.GetNotOddNumbers(array);

            for (int i = 0; i < notOddarray.Length; i++)
            {
                Console.WriteLine(notOddarray[i]);
            }

			Console.Read();
		}
	}
}
