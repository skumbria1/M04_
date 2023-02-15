using System;

namespace GeometricShapes
{
    public class IsoscelesTriangle : Triangle
    {
        private double Side { get; }
        private double Angle { get; }

        private IsoscelesTriangle(double side, double angle) : base(side, side, angle)
        {
            Side = side;
            Angle = angle;
        }

        public static (bool, IsoscelesTriangle) TryCreate(double side, double angle)
        {
            if (side > 0.0 && angle > 0.0 && angle < 180.0)
            {
                return (true, new IsoscelesTriangle(side, angle));
            }
            return (false, null);
        }

        protected override double CalculatePerimeterAlgorithm()
        {
            return 2.0 * Side + CalculateThirdSide();
        }

        protected override double CalculateAreaAlgorithm()
        {
            return 0.5 * Math.Pow(Side, 2.0) * Math.Sin(Angle * (Math.PI / 180.0));
        }
    }
}
