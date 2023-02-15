using System;

namespace GeometricShapes
{
    public class Diamond : Parallelogram
    {
        private double Side { get; }
        private double Angle { get; }

        private Diamond(double side, double angle) : base(side, side, angle)
        {
            Side = side;
            Angle = angle;
        }

        public static (bool, Diamond) TryCreate(double side, double angle)
        {
            if (side > 0.0 && angle > 0.0 && angle < 180.0)
            {
                return (true, new Diamond(side, angle));
            }
            return (false, null);
        }

        protected override double CalculatePerimeterAlgorithm()
        {
            return 4.0 * Side;
        }

        protected override double CalculateAreaAlgorithm()
        {
            return Math.Pow(Side, 2.0) * Math.Sin(Angle * (Math.PI / 180.0));
        }
    }
}
