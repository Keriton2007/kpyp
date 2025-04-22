using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение x: ");
        if (double.TryParse(Console.ReadLine(), out double x))
        {
            double y;

            if (x > 6.7)
            {
                y = 4 - Math.Exp(4 * x); 
            }
            else
            {
                y = Math.Log(3.5 + x);  
            }

            Console.WriteLine($"Значение функции y для x = {x}: {y:F4}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Убедитесь, что введено вещественное число.");
        }
    }
}
