using System;
using System.Linq;
using System.Threading;

class Program
{
    static int[] numbers;
    static int totalSum = 0;
    static object lockObj = new object();

    static void SumEvenNumbers(int start, int end)
    {
        int partialSum = numbers.Skip(start).Take(end - start).Where(n => n % 2 == 0).Sum();

        lock (lockObj)
        {
            totalSum += partialSum;
        }
    }

    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        numbers = Enumerable.Range(1, size).ToArray();
        int numThreads = 4;
        int segmentSize = size / numThreads;

        Thread[] threads = new Thread[numThreads];
        for (int i = 0; i < numThreads; i++)
        {
            int start = i * segmentSize;
            int end = (i == numThreads - 1) ? size : start + segmentSize;
            threads[i] = new Thread(() => SumEvenNumbers(start, end));
            threads[i].Start();
        }

        foreach (var t in threads)
        {
            t.Join();
        }

        Console.WriteLine($"Сумма всех четных чисел: {totalSum}");
    }
}
