using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        string input = Console.ReadLine();

        if (input.Length == 4 && int.TryParse(input, out int number))
        {
            char[] digits = input.ToCharArray();
            char temp = digits[1];
            digits[1] = digits[2];
            digits[2] = temp;

            string result = new string(digits);
            Console.WriteLine("Результат после перестановки: " + result);
        }
        else
        {
            Console.WriteLine("Ошибка: введите корректное четырехзначное число.");
        }
    }
}
