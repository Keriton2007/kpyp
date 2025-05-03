using System;

namespace FunctionTable
{
    class Program
    {
        static void Main()
        {
            
            Console.Write("Введите начало диапазона a: ");
            double a = ReadDouble();

            Console.Write("Введите конец диапазона b: ");
            double b = ReadDouble();

            Console.Write("Введите шаг h: ");
            double h = ReadDouble();

            
            if (h <= 0 || a >= b)
            {
                Console.WriteLine("Некорректные значения. Убедитесь, что h > 0 и a < b.");
                return;
            }


            BuildTable(a, b, h);
        }

        
        static double ReadDouble()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число:");
                }
            }
        }

        
        static double CalculateFunction(double x)
        {
            double y;

            
            if (x < 0)
            {
                y = (2 * x - 1) / (3 * x);
            }
            else if (x >= 0 && x <= 3)
            {
                y = (2 * x + 1) / (3 * x);
            }
            else // x > 3
            {
                y = (2 * x + 1) / (3 * x - 1);
            }

            return y;
        }

        
        static void BuildTable(double a, double b, double h)
        {
            Console.WriteLine("\nТаблица значений функции f(x):");
            Console.WriteLine(" x\t\tf(x)");
            Console.WriteLine("-------------------------");

            for (double x = a; x <= b; x += h)
            {
                double y = CalculateFunction(x);
                Console.WriteLine($"{x:F4}\t\t{y:F4}");
            }
        }
    }
}
