using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите длины сторон треугольника:");

        Console.Write("Сторона a: ");
        double a = GetDouble();

        Console.Write("Сторона b: ");
        double b = GetDouble();

        Console.Write("Сторона c: ");
        double c = GetDouble();


        if (a == b && b == c)
        {
            Console.WriteLine("Треугольник является равносторонним.");
        }
        else
        {
            Console.WriteLine("Треугольник не является равносторонним.");
        }
    }

    static double GetDouble()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double value) && value > 0)
            {
                return value;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное вещественное число:");
            }
        }
    }
}
