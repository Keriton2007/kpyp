using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение n (целое число больше 0):");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Некорректный ввод. Введите положительное целое число:");
        }

        double result = CalculateFunction(n);
        Console.WriteLine($"Результат f({n}) = {result:F4}");
    }

   
    static double CalculateFunction(int n)
    {
        if (n == 1) 
        {
            return 1.0;
        }
        else
        {
            return CalculateFunction(n - 1) * (n - 1) / n; 
        }
    }
}
