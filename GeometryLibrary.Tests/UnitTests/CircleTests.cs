using GeometryLibrary.Models;

namespace GeometryLibrary.Tests.UnitTests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ReturnsCorrectArea()
        {
            var circle = new Circle(5);
            var area = circle.CalculateArea();
            Assert.Equal(Math.PI * 25, area, 5);
        }
    }
}
