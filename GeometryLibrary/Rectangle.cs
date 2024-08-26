using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Rectangle
    {
        public double CalculateArea(double length, double width)
        {
            if (length < 0 || width < 0)
                throw new ArgumentException("Стороны не могут быть отрицательными");

            return length * width;
        }
    }
}
