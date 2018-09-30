using System;
using System.Collections.Generic;
using System.Text;

namespace HW.Classes1
{
	class Figure
	{
		Point point1;
		Point point2;
		Point point3;
		Point point4;
		Point point5;
		string figureName;

		public Figure(Point point1, Point point2, Point point3)
		{
			this.point1 = point1;
			this.point2 = point2;
			this.point3 = point3;
			figureName = "Triangle";
		}

		public Figure(Point point1, Point point2, Point point3, Point point4)
		{
			this.point1 = point1;
			this.point2 = point2;
			this.point3 = point3;
			this.point4 = point4;
			figureName = "Kvadrat";
		}

		public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
		{
			this.point1 = point1;
			this.point2 = point2;
			this.point3 = point3;
			this.point4 = point4;
			this.point5 = point5;
			figureName = "5ungle";
		}

		double LengthSide(Point A, Point B)
		{
			var length = Math.Sqrt((B.X - A.X) + (B.Y - A.Y));
			return length;
		}

		void PerimeterCalculator(params double[] edges)
		{
			double p = 0;
			for (int i = 0; i < edges.Length; i++)
			{
				p += edges[i];
			}
			Console.WriteLine(p);
		}
	}

	class Point
	{
		private int x, y;
		private string text;

		public int X { get => x; }
		public int Y { get => y; }
		public string Text { get => text; }
	}
}
