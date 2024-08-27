using GeometryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibraryTest
{
    public class RectangleTests
    {
        [Fact]
        public void CalculateArea_ShouldReturnCorrectArea()
        {
            // Arrange
            var rectangle = new Rectangle();
            double length = 4;
            double width = 5;
            double expectedArea = length * width;

            // Act
            double actualArea = rectangle.CalculateArea(length, width);

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void CalculateArea_ShouldThrowArgumentException_ForNegativeSides()
        {
            // Arrange
            var rectangle = new Rectangle();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => rectangle.CalculateArea(-4, 5));
        }
    }
}
