using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "f.txt"; 

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Ошибка: файл не найден!");
            return;
        }

        try
        {
            
            double[] numbers = File.ReadAllLines(filePath)
                                   .Select(line => double.Parse(line))
                                   .ToArray();

            
            double max = numbers.Max();
            double min = numbers.Min();
            double sum = max + min;

            
            Console.WriteLine($"Максимальное значение: {max}");
            Console.WriteLine($"Минимальное значение: {min}");
            Console.WriteLine($"Сумма: {sum}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при обработке файла: {ex.Message}");
        }
    }
}

