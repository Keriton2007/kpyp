using System;

namespace FunctionCalculator
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите вещественное значение x (-4 < x):");
                double x = ReadDouble();

                if (x <= -4)
                {
                    throw new ArgumentOutOfRangeException("x", "Значение x должно быть больше -4.");
                }

                double result = CalculateFunction(x);
                Console.WriteLine($"Значение функции f(x): {result:F4}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: Деление на ноль! {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ошибка: Некорректный ввод данных! {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла неизвестная ошибка: {ex.Message}");
            }
        }

        
        static double ReadDouble()
        {
            while (true)
            {
                try
                {
                    return Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите числовое значение:");
                }
            }
        }

        
        static double CalculateFunction(double x)
        {
            if (x <= 1)
            {
                if (x == -1)
                {
                    throw new DivideByZeroException("В выражении f(x) = (3x + 2) / (4x + 4) происходит деление на ноль при x = -1.");
                }
                return (3 * x + 2) / (4 * x + 4);
            }
            else
            {
                return Math.Pow(x, 2); 
            }
        }
    }
}
