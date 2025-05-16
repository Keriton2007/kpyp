using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double A = -1, B = 9;
        int steps = 1000;
        double stepSize = (B - A) / steps;
        double[] results = new double[steps];

        Parallel.For(0, steps, i =>
        {
            double x = A + i * stepSize;
            results[i] = Math.Cos(1 / x);
        });

        Console.WriteLine("Результаты вычислений:");
        for (int i = 0; i < steps; i++)
        {
            Console.WriteLine($"x = {A + i * stepSize:F4}, cos(1/x) = {results[i]:F4}");
        }
    }
}
