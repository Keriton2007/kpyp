using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        double a = GetDouble();

        Console.Write("Введите b: ");
        double b = GetDouble();

        Console.Write("Введите c: ");
        double c = GetDouble();

        Console.Write("Введите d: ");
        double d = GetDouble();

        // Вычисление результата
        double result = (a / b) + (c / d);

        // Вывод результата
        Console.WriteLine($"Результат: (a / b) + (c / d) = {result:F2}");
    }

    static double GetDouble()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double value))
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

