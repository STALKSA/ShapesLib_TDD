﻿namespace ShapesLib
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
<<<<<<< HEAD
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Длина стороны должна быть положительным числом.");
            }

            if (double.IsInfinity(sideA) || double.IsInfinity(sideB) || double.IsInfinity(sideC))
            {
                throw new ArgumentOutOfRangeException("Длина стороны не может быть бесконечностью.");
            }

            if (double.IsNaN(sideA) || double.IsNaN(sideB) || double.IsNaN(sideC))
            {
                throw new ArgumentOutOfRangeException("Длина стороны не может быть NaN (не числом).");
            }

            if (sideA > 1e20 || sideB > 1e20 || sideC > 1e20)
            {

                throw new ArgumentException("Значения слишком велики для вычислений");
            }


=======
           if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Длина стороны должна быть положительным числом.");
            }

>>>>>>> a6a94058b04337d532536359107724aa52316cbf
            if (!IsTriangleValid(sideA, sideB, sideC))
            {
                throw new ArgumentException("Такого треугольника не существует.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Area => CalculateArea();

        private double CalculateArea()
        {
<<<<<<< HEAD
            var perimeter = (SideA + SideB + SideC) / 2;
            return Math.Round(Math.Sqrt(perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC)), 2);
=======
           var perimeter = (SideA + SideB + SideC) / 2;
           return Math.Round(Math.Sqrt(perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC)), 2);
>>>>>>> a6a94058b04337d532536359107724aa52316cbf
        }

        public bool IsRectangular()
        {
<<<<<<< HEAD
            return IsTriangleRectangular(SideA, SideB, SideC);
=======
           return IsTriangleRectangular(SideA, SideB, SideC);
        }

        private bool IsTriangleValid(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        private bool IsTriangleRectangular(double a, double b, double c)
        {
            var sides = new double[] { a, b, c };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
>>>>>>> a6a94058b04337d532536359107724aa52316cbf
        }

        private bool IsTriangleValid(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        private bool IsTriangleRectangular(double a, double b, double c)
        {
            var sides = new double[] { a, b, c };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

    }

}
