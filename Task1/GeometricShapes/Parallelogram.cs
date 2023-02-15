using System;

namespace GeometricShapes
{
    public class Parallelogram : Shape 
    {
        private double SideA { get; }
        private double SideB { get; }
        private double AngleAB { get; }

        protected Parallelogram(double sideA, double sideB, double angleAB)
        {
            SideA = sideA;
            SideB = sideB;
            AngleAB = angleAB;
        }

        public static (bool, Parallelogram) TryCreate(double sideA, double sideB, double angleAB)
        {
            if (sideA > 0.0 && sideB > 0.0 && angleAB > 0.0 && angleAB < 180.0)
            {
                return (true, new Parallelogram(sideA, sideB, angleAB));
            }
            return (false, null);
        }

        protected override double CalculatePerimeterAlgorithm()
        {
            return 2.0 * SideA + 2.0 * SideB;
        }

        protected override double CalculateAreaAlgorithm()
        {
            return SideA * SideB * Math.Sin(AngleAB * (Math.PI / 180.0));
        }
    }
}
