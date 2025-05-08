using System;

class Program
{

    delegate int RandomDelegate();

    static void Main()
    {
        Random rand = new Random();

        RandomDelegate[] delegates = new RandomDelegate[]
        {
            () => rand.Next(1, 100),
            () => rand.Next(1, 100),
            () => rand.Next(1, 100),
            () => rand.Next(1, 100),
            () => rand.Next(1, 100)
        };

        Func<RandomDelegate[], double> calculateAverage = (delArray) =>
        {
            int sum = 0;
            foreach (var del in delArray)
            {
                sum += del();
            }
            return (double)sum / delArray.Length;
        };

        Console.WriteLine($"Среднее арифметическое случайных чисел: {calculateAverage(delegates):F2}");
    }
}

