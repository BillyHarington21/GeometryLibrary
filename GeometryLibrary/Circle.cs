using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Circle
    {
        public double CalculateArea(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным");

            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
