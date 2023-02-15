using System;

namespace GeometricShapes
{
    public class Circle : Ellipse
    {
        private double Radius { get; }
        private Circle(double radius) : base(radius, radius)
        {
            Radius = radius;
        }

        public static (bool, Circle) TryCreate(double radius)
        {
            if (radius > 0.0) return (true, new Circle(radius));
            return (false, null);
        }

        protected override double CalculatePerimeterAlgorithm()
        {
            return 2.0 * Math.PI * Radius;
        }
    }
}
