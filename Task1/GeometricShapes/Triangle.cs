using System;

namespace GeometricShapes
{
    public class Triangle : Shape 
    {
        private double SideA { get; }
        private double SideB { get; }
        private double AngleAB { get; }
        
        protected Triangle(double sideA, double sideB, double angleAB)
        {
            SideA = sideA;
            SideB = sideB;
            AngleAB = angleAB;
        }

        public static (bool, Triangle) TryCreate(double sideA, double sideB, double angleAB)
        {
            if (sideA > 0.0 && sideB > 0.0 && angleAB > 0.0 && angleAB < 180.0)
            {
                return (true, new Triangle(sideA, sideB, angleAB));
            }
            return (false, null);
        }

        protected override double CalculatePerimeterAlgorithm()
        {
            return SideA + SideB + CalculateThirdSide();
        }

        protected virtual double CalculateThirdSide()
        {
            return Math.Sqrt(Math.Pow(SideA, 2.0) + Math.Pow(SideB, 2.0) - 
                2.0 * SideA * SideB * Math.Cos(AngleAB * (Math.PI / 180.0)));
        }

        protected override double CalculateAreaAlgorithm()
        {
            double halfperimeter = CalculatePerimeterAlgorithm() / 2.0;
            return Math.Sqrt(halfperimeter * (halfperimeter - SideA) *
                (halfperimeter - SideB) * (halfperimeter - CalculateThirdSide()));
        }
    }

}
