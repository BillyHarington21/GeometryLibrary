using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Geometry
    {
        // Метод для вычисления площади круга
        public double CalculateCircleArea(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным");

            return Math.PI * Math.Pow(radius, 2);
        }

        // Метод для вычисления площади треугольника по трем сторонам
        public double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Стороны треугольника должны быть положительными");

            // Проверка на существование треугольника
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Сумма двух сторон треугольника должна быть больше третьей");

            double s = (a + b + c) / 2; // Полупериметр
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
