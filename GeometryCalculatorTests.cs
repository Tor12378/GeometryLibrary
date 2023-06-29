using NUnit.Framework;
using GeometryLibrary;

namespace GeometryLibrary.Tests
{
    [TestFixture]
    public class GeometryCalculatorTests
    {
        [Test]
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            double radius = 5;
            double expectedArea = 78.53981633974483;
            Circle circle = new Circle { Radius = radius };

            double actualArea = circle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;
            Triangle triangle = new Triangle { SideA = sideA, SideB = sideB, SideC = sideC };

            double actualArea = triangle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea);
        }

        [Test]
        public void IsRightTriangle_ValidSides_ReturnsTrue()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle { SideA = sideA, SideB = sideB, SideC = sideC };

            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.IsTrue(isRightTriangle);
        }

        [Test]
        public void IsRightTriangle_InvalidSides_ReturnsFalse()
        {
            double sideA = 2;
            double sideB = 3;
            double sideC = 4;
            Triangle triangle = new Triangle { SideA = sideA, SideB = sideB, SideC = sideC };

            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.IsFalse(isRightTriangle);
        }
    }
}
