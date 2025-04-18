using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение аргумента x: ");
        if (double.TryParse(Console.ReadLine(), out double x))
        {
            // Вычисление значения функции
            double numerator = Math.Sin(x) * Math.Sin(x) + 1;
            double denominator = 2 * Math.Sqrt(Math.Exp(2) + 1 - Math.Cos(x - Math.PI));
            double y = Math.Log(2 * x) + (numerator / denominator);

            // Вывод результата
            Console.WriteLine($"Значение функции y для x = {x}: {y:F4}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Убедитесь, что введено вещественное число.");
        }
    }
}

