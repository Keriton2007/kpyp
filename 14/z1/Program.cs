using System;
using System.Threading;

class Program
{
    static AutoResetEvent first = new AutoResetEvent(true);
    static AutoResetEvent second = new AutoResetEvent(false);
    static AutoResetEvent third = new AutoResetEvent(false);

    static void PrintNumbers(int start, int end, AutoResetEvent current, AutoResetEvent next)
    {
        for (int i = start; i <= end; i++)
        {
            current.WaitOne();
            Console.WriteLine(i);
            Thread.Sleep(200); 
            next.Set();
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(() => PrintNumbers(0, 9, first, second)) { Priority = ThreadPriority.Highest };
        Thread t2 = new Thread(() => PrintNumbers(10, 19, second, third)) { Priority = ThreadPriority.Normal };
        Thread t3 = new Thread(() => PrintNumbers(20, 29, third, first)) { Priority = ThreadPriority.Lowest };

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("Все потоки завершены.");
    }
}

