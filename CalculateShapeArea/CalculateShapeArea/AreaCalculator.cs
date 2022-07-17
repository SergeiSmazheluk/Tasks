namespace CalculateShapeArea
{
    public static class AreaCalculator
    {
        public static double CalculateArea(Shape shape) => 
            shape is not null ? shape.Area() : throw new ArgumentNullException(nameof(shape));
    }
}
