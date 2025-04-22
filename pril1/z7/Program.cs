using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ширину комнаты (A): ");
        double A = GetDouble();

        Console.WriteLine("Введите высоту комнаты (B): ");
        double B = GetDouble();

        Console.WriteLine("Введите ширину окна (C): ");
        double C = GetDouble();

        Console.WriteLine("Введите высоту окна (D): ");
        double D = GetDouble();

        Console.WriteLine("Введите ширину двери (N): ");
        double N = GetDouble();

        Console.WriteLine("Введите высоту двери (M): ");
        double M = GetDouble();

        // Вычисление площадей
        double S1 = C * D; // Площадь окна
        double S2 = N * M; // Площадь двери
        double S = 4 * A * B - S1 - S2; // Общая площадь стен для оклеивания обоями

        // Вывод результата
        Console.WriteLine($"Площадь окон: {S1:F2} кв.м.");
        Console.WriteLine($"Площадь дверей: {S2:F2} кв.м.");
        Console.WriteLine($"Площадь стен для оклеивания: {S:F2} кв.м.");
    }

    static double GetDouble()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите вещественное число:");
            }
        }
    }
}

