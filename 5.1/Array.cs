﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _5._1
{
	class Array
	{
		//		Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
		//Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов,
		//среднее арифметическое всех элементов, вывести все нечетные значения.
		public int[] GetArray()
		{
			Random rdm = new Random();
			int arrayLength = rdm.Next(1, 10);
			int[] array = new int[arrayLength];
			for (int i = 0; i < arrayLength; i++)
			{
				array[i] = rdm.Next(1, 100);
			}
			return array;
		}
		
		public int GetMaxArrayValue(int[] array)
		{
			int maxValue = 0;
			for (int i = 0; i < array.Length -1; i++)
			{
				
				if (array[i] > array[i + 1])
				{
					maxValue = array[i];
				}
				else maxValue = array[i +1];
			}
			return maxValue;
		}

		public int GetArraySum(int[] array)
		{
			int sum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				sum += array[i];
			}
			return sum;
		}

		public int MiddleArifmethic(int[] array)
		{
			return GetArraySum(array) / array.Length;
		}

		public void ShowNotOddNumbers(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] % 2 != 0)
				{
					Console.WriteLine(array[i]);
				}
				
			}
		}
	}
}
