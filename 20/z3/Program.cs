using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = ReadInt();

        Task<int> task1 = Task.Run(() => CalculateSum(number));

        Task task2 = task1.ContinueWith(t =>
        {
            Console.WriteLine($"Сумма первой и второй цифры: {t.Result}");
        });

        task2.Wait();
    }

    static int ReadInt()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 100 && number <= 999)
                return number;
            else
                Console.WriteLine("Ошибка: Введите корректное трехзначное число:");
        }
    }

    static int CalculateSum(int number)
    {
        int digit1 = number / 100;
        int digit2 = (number / 10) % 10;

        return digit1 + digit2;
    }
}
