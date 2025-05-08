using System;

class Program
{
    static void Main()
    {

        Func<double, double, double> Add = (a, b) => a + b;
        Func<double, double, double> Sub = (a, b) => a - b;
        Func<double, double, double> Mul = (a, b) => a * b;
        Func<double, double, double> Div = (a, b) => b != 0 ? a / b : throw new DivideByZeroException("Ошибка: деление на ноль!");

        Console.Write("Введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Введите операцию (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        try
        {
            double result = operation switch
            {
                '+' => Add(num1, num2),
                '-' => Sub(num1, num2),
                '*' => Mul(num1, num2),
                '/' => Div(num1, num2),
                _ => throw new InvalidOperationException("Ошибка: неверная операция!")
            };

            Console.WriteLine($"Результат: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
