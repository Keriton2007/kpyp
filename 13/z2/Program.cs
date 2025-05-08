using System;

class Program
{
   
    delegate double CalculationDelegate(double value);

    static double GetPerimeter(double side) => 4 * side;

    static double GetArea(double side) => side * side;

    static double GetTriangleSide(double area) => Math.Sqrt(area * 4 / Math.Sqrt(3));

    static void ExecuteCalculation(CalculationDelegate calcMethod, double value)
    {
        Console.WriteLine($"Результат вычислений: {calcMethod(value):F2}");
    }

    static void Main()
    {
        Console.Write("Введите сторону квадрата: ");
        double squareSide = double.Parse(Console.ReadLine());

        Console.Write("Введите площадь треугольника: ");
        double triangleArea = double.Parse(Console.ReadLine());

        ExecuteCalculation(GetPerimeter, squareSide);
        ExecuteCalculation(GetArea, squareSide);
        ExecuteCalculation(GetTriangleSide, triangleArea);
    }
}
