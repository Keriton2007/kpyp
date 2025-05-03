using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число N (1 <= N <= 20): ");
        if (int.TryParse(Console.ReadLine(), out int N) && N >= 1 && N <= 20)
        {
            double result = 0.0;

            for (int i = 1; i <= N; i++)
            {
                
                double term = 1.0 * i * Math.Pow(-1, i + 1);
                result += term;
            }

            Console.WriteLine($"Результат выражения: {result:F4}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Убедитесь, что N - это целое число от 1 до 20.");
        }
    }
}
