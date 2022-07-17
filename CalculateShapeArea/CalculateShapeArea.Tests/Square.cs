namespace CalculateShapeArea.Tests
{
    internal class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side > 0 ? side : throw new ArgumentException(nameof(side));
        }

        public override double Area() => side * side;
    }
}
