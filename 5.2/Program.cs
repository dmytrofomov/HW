using System;

namespace _5._2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера с
			//возможностью изменения числа строк и столбцов.
			//Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков.

			var matrix = new Matrix();
			var m = matrix.CreateMatrix(8, 10);
			matrix.ShowMatrix(m);
			Console.WriteLine();
			var dm = matrix.GetDerivativeMatrix(10, 5, m);
			matrix.ShowMatrix(dm);
			Console.Read();

		}
	}
}
