using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите угол в градусах и нажмите <Enter>:");

        // Чтение угла от пользователя
        if (double.TryParse(Console.ReadLine(), out double angleInDegrees))
        {
            // Перевод угла из градусов в радианы
            double alpha = angleInDegrees * Math.PI / 180;

            // Вычисление по первой формуле
            double z1 = (Math.Sin(2 * alpha) + Math.Sin(5 * alpha) - Math.Sin(3 * alpha)) /
                        (Math.Cos(alpha) + 1 - 2 * Math.Pow(Math.Sin(2 * alpha), 2));

            // Вычисление по второй формуле
            double z2 = 2 * Math.Sin(alpha);

            // Вывод результатов
            Console.WriteLine($"Результат по формуле z1: {z1:F4}");
            Console.WriteLine($"Результат по формуле z2: {z2:F4}");

            // Проверка совпадения результатов
            if (Math.Abs(z1 - z2) < 0.0001)
            {
                Console.WriteLine("Результаты формул совпадают (с учётом погрешности).");
            }
            else
            {
                Console.WriteLine("Результаты формул не совпадают.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Убедитесь, что введено число.");
        }
    }
}

