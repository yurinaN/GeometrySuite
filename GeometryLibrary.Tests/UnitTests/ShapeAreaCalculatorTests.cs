using GeometryLibrary.Factories;

namespace GeometryLibrary.Tests.UnitTests
{
    public class ShapeAreaCalculatorTests
    {
        [Fact]
        public void CalculateArea_Returns_Correct_Circle_Area()
        {
            // Arrange
            var circle = ShapeFactory.CreateCircle(5);

            // Act
            var result = ShapeAreaCalculator.CalculateArea(circle);

            // Assert
            Assert.Equal(78.54, result, 2);
        }

        [Fact]
        public void CalculateArea_Returns_Correct_Triangle_Area()
        {
            // Arrange
            var triangle = ShapeFactory.CreateTriangle(3, 4, 5);

            // Act
            var result = ShapeAreaCalculator.CalculateArea(triangle);

            // Assert
            Assert.Equal(6, result);
        }
    }
}
