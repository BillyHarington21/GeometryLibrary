using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class GeometryCalculator
    {
        private readonly Circle _circle = new Circle();
        private readonly Rectangle _rectangle = new Rectangle();
        private readonly Triangle _triangle = new Triangle();

        public double CalculateArea(params double[] sides)
        {
            switch (sides.Length)
            {
                case 1:
                    // Площадь круга
                    return _circle.CalculateArea(sides[0]);

                case 2:
                    // Площадь прямоугольника или квадрата
                    return _rectangle.CalculateArea(sides[0], sides[1]);

                case 3:
                    // Площадь треугольника
                    return _triangle.CalculateArea(sides[0], sides[1], sides[2]);

                default:
                    throw new ArgumentException("Недопустимое количество параметров");
            }
        }
    }
}
