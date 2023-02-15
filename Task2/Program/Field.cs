using System;

namespace Program
{
    public class Field
    {
        private int Height { get; }
        private int Width { get; }

        private Field(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public static (bool, Field) TryCreate(int height, int width)
        {
            if (height > 0 && width > 0) return (true, new Field(height, width));
            return (false, null);
        }

        public void Draw() { }
    }
}
