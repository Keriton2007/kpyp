using System;

namespace FunctionTable
{
    /// <summary>
    /// Основной класс программы, выполняющий вычисления функции в заданном диапазоне.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод программы. Запрашивает диапазон значений и вызывает методы вычислений.
        /// </summary>
        static void Main()
        {
            Console.Write("Введите начало диапазона a: ");
            double a = ReadDouble();

            Console.Write("Введите конец диапазона b: ");
            double b = ReadDouble();

            Console.Write("Введите шаг h: ");
            double h = ReadDouble();

            if (h <= 0 || a >= b)
            {
                Console.WriteLine("Некорректные значения. Убедитесь, что h > 0 и a < b.");
                return;
            }

            BuildTable(a, b, h);
        }

        /// <summary>
        /// Запрашивает ввод числа у пользователя и выполняет проверку.
        /// </summary>
        /// <returns>Число, введённое пользователем.</returns>
        static double ReadDouble()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число:");
                }
            }
        }

        /// <summary>
        /// Вычисляет значение функции f(x) на основе условий.
        /// </summary>
        /// <param name="x">Точка, в которой вычисляется значение функции.</param>
        /// <returns>Результат вычисления функции.</returns>
        static double CalculateFunction(double x)
        {
            return x < 0 ? (2 * x - 1) / (3 * x) :
                   (x >= 0 && x <= 3) ? (2 * x + 1) / (3 * x) :
                   (2 * x + 1) / (3 * x - 1);
        }

        /// <summary>
        /// Создаёт таблицу значений функции для заданного диапазона.
        /// </summary>
        /// <param name="a">Начальное значение диапазона.</param>
        /// <param name="b">Конечное значение диапазона.</param>
        /// <param name="h">Шаг вычислений.</param>
        static void BuildTable(double a, double b, double h)
        {
            Console.WriteLine("\nТаблица значений функции f(x):");
            Console.WriteLine(" x\t\tf(x)");
            Console.WriteLine("-------------------------");

            for (double x = a; x <= b; x += h)
            {
                Console.WriteLine($"{x:F4}\t\t{CalculateFunction(x):F4}");
            }
        }
    }
}

