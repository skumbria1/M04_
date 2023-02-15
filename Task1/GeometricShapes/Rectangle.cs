using System;

namespace GeometricShapes
{
    public class Rectangle : Parallelogram
    {
        private double SideA { get; }
        private double SideB { get; }

        protected Rectangle(double sideA, double sideB) : base(sideA, sideB, 90.0)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public static (bool, Rectangle) TryCreate(double sideA, double sideB)
        {
            if (sideA > 0.0 && sideB > 0.0) return (true, new Rectangle(sideA, sideB));
            return (false, null);
        }

        protected override double CalculateAreaAlgorithm()
        {
            return SideA * SideB;
        }
    }
}
