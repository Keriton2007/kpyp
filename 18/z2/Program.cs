using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "numbers.txt";

        File.WriteAllLines(fileName, new string[]
        {
            "12", "5", "20", "7", "15", "30", "3", "10", "25"
        });

        Console.WriteLine($"Файл {fileName} создан с тестовыми числами.");

        Console.Write("Введите границы интервала [a, b]: ");
        string[] intervalInput = Console.ReadLine().Split();
        int a = int.Parse(intervalInput[0]);
        int b = int.Parse(intervalInput[1]);

        Queue<int> inRange = new Queue<int>();
        Queue<int> lessThanA = new Queue<int>();
        Queue<int> greaterThanB = new Queue<int>();

        foreach (string line in File.ReadLines(fileName))
        {
            if (int.TryParse(line, out int number))
            {
                if (number >= a && number <= b)
                    inRange.Enqueue(number);
                else if (number < a)
                    lessThanA.Enqueue(number);
                else
                    greaterThanB.Enqueue(number);
            }
        }

        Console.WriteLine("Числа из интервала [a, b]: " + string.Join(" ", inRange));
        Console.WriteLine("Числа меньше a: " + string.Join(" ", lessThanA));
        Console.WriteLine("Числа больше b: " + string.Join(" ", greaterThanB));
    }
}
