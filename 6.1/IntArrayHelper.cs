using System;
using System.Collections.Generic;
using System.Text;

namespace _6._1
{
	class IntArrayHelper
	{
		internal static void Fill(int[] array, int value)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = value;
			}
		}

		internal static void SequenceFill(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = i + 1;
			}
		}

		internal static void Print(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write($"{array[i]}, ");
			}
		}
	}
}
