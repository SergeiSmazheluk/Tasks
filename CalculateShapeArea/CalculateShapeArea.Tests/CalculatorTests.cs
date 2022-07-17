using NUnit.Framework;

namespace CalculateShapeArea.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void TestCicleAreaCalculation()
        {
            var circle = new Circle(5d);
            var expected = 15.707963267948966d;
            var ectual = AreaCalculator.CalculateArea(circle);
            Assert.AreEqual(expected, ectual, 0.000001);
        }

        [TestCase(10d, ExpectedResult = 100d)]
        public double CalculateAreaOfSquare(double side) => AreaCalculator.CalculateArea(new Square(side));

        [Test]
        public void CalculateArea_With_Null_Shape_ThrowArgumentNullException()
            => Assert.Throws<ArgumentNullException>(() => AreaCalculator.CalculateArea(null!));

        [Test]
        public void Create_Circle_With_NegativeRadius_ThrowArgumentException()
            => Assert.Throws<ArgumentException>(() => new Circle(-5d));

        [Test]
        public void Create_Square_With_NegativeSide_ThrowArgumentException()
            => Assert.Throws<ArgumentException>(() => new Square(-5d));
    }
}