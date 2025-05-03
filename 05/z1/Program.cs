using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Введите количество элементов массива:");
        int n = int.Parse(Console.ReadLine());
        double[] array = new double[n];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nНомера элементов, удовлетворяющих условию 0 < x_i < 3.2:");
        bool hasMatches = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < 3.2)
            {
                Console.WriteLine($"Номер элемента: {i + 1}");
                hasMatches = true;
            }
        }

        if (!hasMatches)
        {
            Console.WriteLine("Нет элементов, удовлетворяющих заданному условию.");
        }
    }
}
