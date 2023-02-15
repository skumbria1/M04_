using System;
using MemoizerLib;

namespace GeometricShapes
{
    public abstract class Shape
    {
        private double? _perimeter;
        private double? _area;
        public double Perimeter => (double)(_perimeter ??= CalculatePerimeter());
        public double Area => (double)(_area ??= CalculateArea());
        protected abstract double CalculatePerimeterAlgorithm();
        protected abstract double CalculateAreaAlgorithm();
        protected Func<double> CalculateAreaMemoized;
        protected Func<double> CalculatePerimeterMemoized;
        private double CalculatePerimeter()
        {
            if (object.ReferenceEquals(CalculatePerimeterMemoized, null))
            {
                CalculatePerimeterMemoized = Memoizer.Memoize<double>(CalculatePerimeterAlgorithm);
            }
            return CalculatePerimeterMemoized();
        }

        private double CalculateArea()
        {
            if (object.ReferenceEquals(CalculateAreaMemoized, null))
            {
                CalculateAreaMemoized = Memoizer.Memoize<double>(CalculateAreaAlgorithm);
            }
            return CalculateAreaMemoized();
        }

    }
}
