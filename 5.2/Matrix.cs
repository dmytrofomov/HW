using System;
using System.Collections.Generic;
using System.Text;

namespace _5._2
{
	class Matrix
	{
		public int[,] CreateMatrix(int higth, int width)
		{
			int[,] matrix = new int[higth, width];
			Random rd = new Random();
			for (int i = 0; i < higth; i++)
			{
				for (int j = 0; j < width; j++)
				{
					matrix[i,j] = rd.Next(1,10);
				}
			}
			return matrix;
		}

		public void ShowMatrix(int[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(" " + matrix[i,j]);
				}
				Console.WriteLine();
			}
		}

		public int[,] GetDerivativeMatrix(int higth, int width, int[,] matrix)
		{
			if (higth > matrix.GetLength(0) || width > matrix.GetLength(1))
			{
				Console.WriteLine("Derevative matrix cannot be bigest than Base Matrix");
				return matrix;
			}
			int[,] derevativeMatrix = new int[higth, width];

			for (int i = 0; i < higth; i++)
			{
				for (int j = 0; j < width; j++)
				{
					derevativeMatrix[i, j] = matrix[i, j];
				}
			}
			return derevativeMatrix;
		}
	}
}
