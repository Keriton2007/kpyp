using System;

class Program
{

    delegate double CalculationDelegate(double value);

    
    static double GetPerimeter(double side)
    {
        if (side <= 0) throw new ArgumentException("Ошибка: сторона квадрата должна быть положительной!");
        return 4 * side;
    }

    static double GetArea(double side)
    {
        if (side <= 0) throw new ArgumentException("Ошибка: сторона квадрата должна быть положительной!");
        return Math.Pow(side, 2);
    }

    
    static double GetTriangleSide(double area)
    {
        if (area <= 0) throw new ArgumentException("Ошибка: площадь должна быть положительной!");
        return Math.Sqrt(area * 4 / Math.Sqrt(3));
    }

    static void Main()
    {
        try
        {
            Console.Write("Введите сторону квадрата: ");
            double squareSide = double.Parse(Console.ReadLine());

            Console.Write("Введите площадь треугольника: ");
            double triangleArea = double.Parse(Console.ReadLine());

            
            CalculationDelegate calcDel;

            calcDel = GetPerimeter;
            Console.WriteLine($"Периметр квадрата: {calcDel(squareSide):F2}");

            calcDel = GetArea;
            Console.WriteLine($"Площадь квадрата: {calcDel(squareSide):F2}");

            calcDel = GetTriangleSide;
            Console.WriteLine($"Сторона равностороннего треугольника: {calcDel(triangleArea):F2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
