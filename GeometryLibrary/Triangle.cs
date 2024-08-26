using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Triangle
    {

        public double CalculateArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Стороны треугольника должны быть положительными");

            // Проверка на существование треугольника
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Сумма двух сторон треугольника должна быть больше третьей");

            double s = (a + b + c) / 2; // Полупериметр
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            // Проверка на прямоугольный треугольник (теорема Пифагора)
            bool isRightTriangle = IsRightTriangle(a, b, c);

            if (isRightTriangle)
            {
                Console.WriteLine("Этот треугольник прямоугольный.");
            }

            return area;


        }
        private bool IsRightTriangle(double a, double b, double c)
        {
            // Сортировка сторон, чтобы найти гипотенузу (наибольшую сторону)
            double[] sides = { a, b, c };
            Array.Sort(sides);

            // Проверка на теорему Пифагора: c² = a² + b²
            return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-10;
        }
    }
}
