using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void SumNumbers()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            Thread.Sleep(50);
        }
        stopwatch.Stop();
        Console.WriteLine($"Сумма чисел: {sum}, Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
    }

    static void Main()
    {
        Thread t1 = new Thread(SumNumbers);
        Thread t2 = new Thread(SumNumbers);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Оба потока завершены.");
    }
}
