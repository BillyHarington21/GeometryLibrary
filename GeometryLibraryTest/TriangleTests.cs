using GeometryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibraryTest
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ShouldReturnCorrectArea()
        {
            // Arrange
            var triangle = new Triangle();
            double a = 3;
            double b = 4;
            double c = 5;
            double s = (a + b + c) / 2;
            double expectedArea = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            // Act
            double actualArea = triangle.CalculateArea(a, b, c);

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 5);
        }

        [Fact]
        public void CalculateArea_ShouldThrowArgumentException_ForInvalidTriangle()
        {
            // Arrange
            var triangle = new Triangle();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => triangle.CalculateArea(1, 2, 3));
        }

        [Fact]
        public void CalculateArea_ShouldIdentifyRightTriangle()
        {
            // Arrange
            var triangle = new Triangle();
            double a = 3;
            double b = 4;
            double c = 5;

            // Act
            var result = triangle.CalculateArea(a, b, c);

            // Assert
            Assert.True(Math.Abs(result - 6) < 1e-5);
        }
    }
}
