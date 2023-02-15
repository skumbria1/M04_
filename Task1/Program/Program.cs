using System;
using GeometricShapes;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var (ellipseSuccess, ellipse) = Ellipse.TryCreate(2, 2);
            if (ellipseSuccess)
            {
                Console.WriteLine(ellipse.Area);
            }

            var (circleSuccess, circle) = Circle.TryCreate(3);
            if (circleSuccess)
            {
                Console.WriteLine(circle.Area);
                Console.WriteLine(circle.Area);
            }

            var (rtriangleSuccess, rtriangle) = RightTriangle.TryCreate(4, 3);
            if (rtriangleSuccess)
            {
                Console.WriteLine(rtriangle.Perimeter);
            }

            var (rectangleSuccess, rectangle) = Rectangle.TryCreate(6, 4);
            if (rectangleSuccess)
            {
                Console.WriteLine(rectangle.Area);
            }
        }
    }
}
