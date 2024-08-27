using GeometryLibrary;
using Xunit;

namespace GeometryLibraryTest
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ShouldReturnCorrectArea()
        {
            // Arrange
            var circle = new Circle();
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            // Act
            double actualArea = circle.CalculateArea(radius);

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 5);
        }

        [Fact]
        public void CalculateArea_ShouldThrowArgumentException_ForNegativeRadius()
        {
            // Arrange
            var circle = new Circle();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => circle.CalculateArea(-5));
        }
    }
}