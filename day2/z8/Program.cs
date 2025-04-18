using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число A: ");
        int A = GetInt();

        Console.Write("Введите число B: ");
        int B = GetInt();

        if (A >= B)
        {
            Console.WriteLine("Число A должно быть меньше B. Попробуйте снова.");
        }
        else
        {
            long product = 1;

            for (int i = A; i <= B; i++)
            {
                product *= i; 
            }

            Console.WriteLine($"Произведение всех чисел от {A} до {B} включительно: {product}");
        }
    }

    static int GetInt()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int value) && value > 0)
            {
                return value;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число:");
            }
        }
    }
}
