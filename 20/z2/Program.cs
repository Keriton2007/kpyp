using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение α в градусах: ");
        double alpha = ReadDouble();

        Task<double> task1 = Task.Run(() =>
        {
            Thread.Sleep(2000);
            return CalculateZ1(alpha);
        });

        Task<double> task2 = Task.Run(() =>
        {
            Thread.Sleep(3000);
            return CalculateZ2(alpha);
        });

        Task.WhenAll(task1, task2).Wait();
        Console.WriteLine($"Результаты (все задачи выполнены): z1 = {task1.Result:F4}, z2 = {task2.Result:F4}");

        Task.WhenAny(task1, task2).Wait();
        Console.WriteLine($"Первая выполненная задача дала результат: {(task1.IsCompleted ? $"z1 = {task1.Result:F4}" : $"z2 = {task2.Result:F4}")}");
    }

    static double ReadDouble()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double value))
                return value;
            else
                Console.WriteLine("Ошибка: Введите корректное число:");
        }
    }

    static double CalculateZ1(double alpha)
    {
        double radAlpha = Math.PI * alpha / 180;
        return (Math.Sin(2 * radAlpha) + Math.Sin(5 * radAlpha) - Math.Sin(3 * radAlpha)) /
               (Math.Cos(radAlpha) + 1 - 2 * Math.Pow(Math.Sin(2 * radAlpha), 2));
    }

    static double CalculateZ2(double alpha)
    {
        double radAlpha = Math.PI * alpha / 180;
        return 2 * Math.Sin(radAlpha);
    }
}
