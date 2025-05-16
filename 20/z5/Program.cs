using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 34, 7, 87, 12 };

        Parallel.ForEach(numbers, (n, state) =>
        {
            if (n > 50) // Прерывание при достижении N > 50
            {
                Console.WriteLine($"Прерывание выполнения при N = {n}");
                state.Stop();
                return;
            }

            long sum = 0, product = 1;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
                product *= i;
            }

            Console.WriteLine($"N = {n}, Сумма: {sum}, Произведение: {product}");
        });

        Console.WriteLine("Завершение программы.");
    }
}
