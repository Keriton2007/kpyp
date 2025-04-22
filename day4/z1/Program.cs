using System;

class Program
{
    static void Main()
    {
        try
        {
            
            Console.WriteLine("Введите значение x для выражения y = (x + 4) / (x + 8):");
            double x1 = ReadDouble();
            double y1 = CalculateFirstExpression(x1);
            Console.WriteLine($"Результат первого выражения: y = {y1:F4}");

            
            Console.WriteLine("\nВведите значение x для выражения y = cos^3(x) / (x - 1):");
            double x2 = ReadDouble();
            double y2 = CalculateSecondExpression(x2);
            Console.WriteLine($"Результат второго выражения: y = {y2:F4}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: Деление на ноль! {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка: Некорректный ввод данных! {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла неизвестная ошибка: {ex.Message}");
        }
    }

   
    static double ReadDouble()
    {
        while (true)
        {
            try
            {
                return Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите числовое значение:");
            }
        }
    }

    
    static double CalculateFirstExpression(double x)
    {
        if (x == -8)
        {
            throw new DivideByZeroException("В первом выражении деление на ноль при x = -8.");
        }
        return (x + 4) / (x + 8);
    }


    static double CalculateSecondExpression(double x)
    {
        if (x == 1)
        {
            throw new DivideByZeroException("Во втором выражении деление на ноль при x = 1.");
        }
        return Math.Pow(Math.Cos(x), 3) / (x - 1);
    }
}
