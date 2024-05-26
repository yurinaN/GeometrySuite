using GeometryLibrary;
using GeometryLibrary.Factories;
using GeometryLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeometryApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GeometryController : ControllerBase
    {
        [HttpGet("circle/area")]
        public IActionResult GetCircleArea(double radius)
        {
            var circle = ShapeFactory.CreateCircle(radius);
            var area = ShapeAreaCalculator.CalculateArea(circle);
            return Ok(area);
        }

        [HttpGet("triangle/area")]
        public IActionResult GetTriangleArea(double sideA, double sideB, double sideC)
        {
            var triangle = ShapeFactory.CreateTriangle(sideA, sideB, sideC);
            var area = ShapeAreaCalculator.CalculateArea(triangle);
            return Ok(area);
        }

        [HttpGet("triangle/isRight")]
        public IActionResult IsRightTriangle(double sideA, double sideB, double sideC)
        {
            var triangle = ShapeFactory.CreateTriangle(sideA, sideB, sideC);
            var isRight = (triangle as Triangle)!.IsRightTriangle();
            return Ok(isRight);
        }
    }
}
