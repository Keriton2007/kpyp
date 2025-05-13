using System;

namespace TriangleRectangleLibrary
{
    public class Triangle
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
                throw new ArgumentException("Ошибка: такой треугольник не существует!");

            SideA = a;
            SideB = b;
            SideC = c;
        }

        public static bool IsValidTriangle(double a, double b, double c) =>
            a + b > c && a + c > b && b + c > a;

        public double GetPerimeter() => SideA + SideB + SideC;

        public double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public string GetTriangleType()
        {
            if (SideA == SideB && SideB == SideC) return "Равносторонний";
            if (SideA == SideB || SideA == SideC || SideB == SideC) return "Равнобедренный";
            return "Разносторонний";
        }
    }
}

