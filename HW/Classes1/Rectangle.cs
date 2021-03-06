﻿using System;

namespace HW.Classes1
{
    class Rectangle
    {
        public double Area => AreaCalculator();
        public double Perimete => PerimeterCalculator();

        private double side1, side2;

        public Rectangle(double a, double b)
        {
            side1 = a;
            side2 = b;
        }

        public double AreaCalculator()
        {
            var side3 = Math.Sqrt(side1 * side1 + side2 * side2);
            return side1 * side2 * side3;
        }

        public double PerimeterCalculator()
        {
            return AreaCalculator() / side1 / side2 + side1 + side2;
        }

    }
}
