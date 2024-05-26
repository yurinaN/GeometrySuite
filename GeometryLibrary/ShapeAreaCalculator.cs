using GeometryLibrary.Models;

namespace GeometryLibrary
{
    public static class ShapeAreaCalculator
    {
        public static double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
