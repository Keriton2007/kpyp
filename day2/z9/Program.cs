using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите начало отрезка A: ");
        double A = GetDouble();

        Console.Write("Введите конец отрезка B: ");
        double B = GetDouble();

        Console.Write("Введите количество точек M: ");
        int M = GetInt();

        if (M <= 0)
        {
            Console.WriteLine("Количество точек M должно быть больше нуля.");
            return;
        }

        double H = (B - A) / M; 
        Console.WriteLine($"Шаг H: {H:F4}");

        Console.WriteLine($"Значения функции F(x) на отрезке [{A}, {B}]:");
        for (int i = 0; i <= M; i++)
        {
            double x = A + i * H; 
            double Fx = Function(x); 

            Console.WriteLine($"x = {x:F4}, F(x) = {Fx:F4}");
        }
    }

    static double Function(double x)
    {

        return Math.Sin(x) + Math.Pow(x, 2); 
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

    static int GetInt()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int value) && value > 0)
            {
                return value;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число:");
            }
        }
    }
}
