namespace CalculateShapeArea.Tests
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius > 0 ? radius : throw new ArgumentException(nameof(radius));
        }

        public override double Area() => this.radius * Math.PI;
    }
}
