using System;

namespace TriangleRectangleLibrary
{
    public class Rectangle
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException("Ошибка: стороны должны быть положительными!");

            Width = width;
            Height = height;
        }

        public double GetPerimeter() => 2 * (Width + Height);
        public double GetArea() => Width * Height;
    }
}

