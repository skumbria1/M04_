using System;

namespace GeometricShapes
{
    public class Square : Rectangle
    {
        private double Side { get; }

        private Square(double side) : base(side, side)
        {
            Side = side;
        }

        public static (bool, Square) TryCreate(double side)
        {
            if (side > 0.0) return (true, new Square(side));
            return (false, null);
        }

        protected override double CalculatePerimeterAlgorithm()
        {
            return 4.0 * Side;
        }

        protected override double CalculateAreaAlgorithm()
        {
            return Math.Pow(Side, 2.0);
        }
    }
}
