using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трёхзначное число и нажмите <Enter>:");

        // Чтение ввода пользователя
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 100 && number <= 999)
        {
            // Извлечение первой и второй цифр
            int firstDigit = number / 100;         // Первая цифра
            int secondDigit = (number / 10) % 10;  // Вторая цифра

            // Вычисление суммы
            int sum = firstDigit + secondDigit;

            Console.WriteLine($"Сумма первой и второй цифр числа {number}: {sum}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Убедитесь, что введено трёхзначное число.");
        }
    }
}

