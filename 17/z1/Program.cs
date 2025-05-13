using System;
using TriangleRectangleLibrary;

class Program
{
    static void Main()
    {
        try
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"Треугольник: {triangle.GetTriangleType()}");
            Console.WriteLine($"Периметр: {triangle.GetPerimeter():F2}");
            Console.WriteLine($"Площадь: {triangle.GetArea():F2}\n");

            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Прямоугольник:");
            Console.WriteLine($"Периметр: {rectangle.GetPerimeter():F2}");
            Console.WriteLine($"Площадь: {rectangle.GetArea():F2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
