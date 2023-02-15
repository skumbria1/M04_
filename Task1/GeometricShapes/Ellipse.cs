using System;

namespace GeometricShapes
{
    public class Ellipse : Shape 
    {
        private double SemiaxisA { get; }
        private double SemiaxisB { get; }

        protected Ellipse(double semiaxisA, double semiaxisB) 
        {
            SemiaxisA = semiaxisA;
            SemiaxisB = semiaxisB;
        }

        public static (bool, Ellipse) TryCreate(double semiaxisA, double semiaxisB)
        {
            if (semiaxisA > 0.0 && semiaxisB > 0.0)
            {
                return (true, new Ellipse(semiaxisA, semiaxisB));
            }
            return (false, null);
        }

        protected override double CalculatePerimeterAlgorithm() // Ramanujan formula
        {
            return Math.PI * (3.0 * (SemiaxisA + SemiaxisB) -
                       Math.Sqrt((3.0 * SemiaxisA + SemiaxisB) *
                       (SemiaxisA + 3.0 * SemiaxisB)));
        }
        protected override double CalculateAreaAlgorithm()
        {
            return Math.PI * SemiaxisA * SemiaxisB;
        }
    }
}
