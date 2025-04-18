using System;

class Program
{
    static void Main()
    {
        // Константа для перевода верст в километры
        const double VerstToKilometers = 1.0668;

        Console.WriteLine("Пересчет расстояния из верст в километры.");
        Console.Write("Введите расстояние в верстах и нажмите <Enter>: ");

        // Чтение входных данных от пользователя
        if (double.TryParse(Console.ReadLine(), out double verst))
        {
            // Пересчет расстояния
            double kilometers = verst * VerstToKilometers;

            // Вывод результата с форматированием до двух знаков после запятой
            Console.WriteLine($"{verst} верст(а/ы) - это {kilometers:F2} км.");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Убедитесь, что введено число.");
        }
    }
}
