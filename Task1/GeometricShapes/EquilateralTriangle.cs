using System;

namespace GeometricShapes
{
    public class EquilateralTriangle : Triangle
    {
        private double Side { get; }
        private EquilateralTriangle(double side) : base(side, side, 60.0)
        {
            Side = side;
        }

        public static (bool, EquilateralTriangle) TryCreate(double side)
        {
            if (side > 0.0) return (true, new EquilateralTriangle(side));
            return (false, null);
        }

        protected override double CalculatePerimeterAlgorithm()
        {
            return 3.0 * Side;
        }

        protected override double CalculateAreaAlgorithm()
        {
            return Math.Sqrt(3.0) / 4.0 * Math.Pow(Side, 2.0);
        }
    }
}
