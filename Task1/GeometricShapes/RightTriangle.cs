using System;

namespace GeometricShapes
{
    public class RightTriangle : Triangle
    {
        private double SideA { get; }
        private double SideB { get; }
        private RightTriangle(double sideA, double sideB) : base(sideA, sideB, 90.0)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public static (bool, RightTriangle) TryCreate(double sideA, double sideB)
        {
            if (sideA > 0.0 && sideB > 0.0) return (true, new RightTriangle(sideA, sideB));
            return (false, null);
        }

        protected override double CalculateThirdSide()
        {
            return Math.Sqrt(Math.Pow(SideA, 2.0) + Math.Pow(SideB, 2.0));
        }

        protected override double CalculateAreaAlgorithm()
        {
            return (SideA * SideB) / 2.0;
        }
    }
}
