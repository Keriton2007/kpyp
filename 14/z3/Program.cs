using System;
using System.Threading;

class Program
{
    static int A, N;
    static object lockObj = new object();

    static void SumMethod()
    {
        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += A + i;
        }
        Console.WriteLine($"Сумма: {sum}");
    }

    static void ProductMethod()
    {
        lock (lockObj) 
        {
            int product = 1;
            for (int i = 1; i <= N; i++)
            {
                product *= A + i;
            }
            Console.WriteLine($"Произведение: {product}");
        }
    }

    static void Main()
    {
        Console.Write("Введите A: ");
        A = int.Parse(Console.ReadLine());

        Console.Write("Введите N: ");
        N = int.Parse(Console.ReadLine());

        Thread t1 = new Thread(SumMethod);
        Thread t2 = new Thread(SumMethod);
        Thread t3 = new Thread(ProductMethod);
        Thread t4 = new Thread(ProductMethod);

        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();

        t3.Start();
        t4.Start();
        t3.Join();
        t4.Join();

        Console.WriteLine("Все потоки завершены.");
    }
}
