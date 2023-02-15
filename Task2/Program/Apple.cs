using System;

namespace Program
{
    public class Apple : Bonus
    {
        
        private int _gainablePoints = 1;
        public int GainablePoints { get => _gainablePoints; }
        private Apple(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public static (bool, Apple) TryCreate(int x, int y)
        {
            if (x > 0 && y > 0) return (true, new Apple(x, y));
            return (false, null);
        }
    }
}
