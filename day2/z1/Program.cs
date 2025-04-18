using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        double num1 = GetDouble();

        Console.Write("Введите второе число: ");
        double num2 = GetDouble();


        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        double quotient = num2 != 0 ? num1 / num2 : double.NaN; 

        
        Console.WriteLine($"Сумма: {sum:F2}");
        Console.WriteLine($"Разность: {difference:F2}");
        Console.WriteLine($"Произведение: {product:F2}");
        Console.WriteLine($"Частное: {(num2 != 0 ? quotient.ToString("F2") : "Деление на ноль невозможно")}");
    }

    static double GetDouble()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число:");
            }
        }
    }
}
