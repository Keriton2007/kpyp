using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        int number = ReadInt();

        Task<int> task1 = new Task<int>(() => SwapDigits(number));
        task1.Start();
        Console.WriteLine($"Вариант 1 (Start): {task1.Result}");

        Task<int> task2 = Task.Run(() => SwapDigits(number));
        Console.WriteLine($"Вариант 2 (Run): {task2.Result}");

        Task<int> task3 = Task.Factory.StartNew(() => SwapDigits(number));
        Console.WriteLine($"Вариант 3 (Factory.StartNew): {task3.Result}");
    }

    static int ReadInt()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 1000 && number <= 9999)
                return number;
            else
                Console.WriteLine("Ошибка: Введите корректное четырехзначное число:");
        }
    }

    static int SwapDigits(int number)
    {
        int digit1 = number / 1000;
        int digit2 = (number / 100) % 10;
        int digit3 = (number / 10) % 10;
        int digit4 = number % 10;

        return digit1 * 1000 + digit3 * 100 + digit2 * 10 + digit4;
    }
}
