using GeometryLibrary.Models;

namespace GeometryLibrary.Tests.UnitTests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ReturnsCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);
            var area = triangle.CalculateArea();
            Assert.Equal(6, area, 5);
        }

        [Fact]
        public void IsRightTriangle_ReturnsTrue_ForRightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            var isRight = triangle.IsRightTriangle();
            Assert.True(isRight);
        }

        [Fact]
        public void IsRightTriangle_ReturnsFalse_ForNonRightTriangle()
        {
            var triangle = new Triangle(3, 4, 6);
            var isRight = triangle.IsRightTriangle();
            Assert.False(isRight);
        }
    }
}
