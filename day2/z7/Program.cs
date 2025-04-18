using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите начало диапазона (A): ");
        int A = GetInt();

        Console.Write("Введите конец диапазона (B): ");
        int B = GetInt();

        Console.Write("Введите цифру X: ");
        int X = GetLastDigit();

        Console.Write("Введите цифру Y: ");
        int Y = GetLastDigit();

        if (A > B)
        {
            Console.WriteLine("Начало диапазона (A) должно быть меньше или равно концу диапазона (B).");
            return;
        }

        Console.WriteLine("\nРешение с использованием цикла for:");
        ForLoopSolution(A, B, X, Y);

        Console.WriteLine("\nРешение с использованием цикла while:");
        WhileLoopSolution(A, B, X, Y);

        Console.WriteLine("\nРешение с использованием цикла do while:");
        DoWhileLoopSolution(A, B, X, Y);
    }

    static void ForLoopSolution(int A, int B, int X, int Y)
    {
        for (int i = B; i >= A; i--)
        {
            if (i % 2 == 0 && (i % 10 == X || i % 10 == Y))
            {
                Console.WriteLine(i);
            }
        }
    }

    static void WhileLoopSolution(int A, int B, int X, int Y)
    {
        int i = B;
        while (i >= A)
        {
            if (i % 2 == 0 && (i % 10 == X || i % 10 == Y))
            {
                Console.WriteLine(i);
            }
            i--;
        }
    }

    static void DoWhileLoopSolution(int A, int B, int X, int Y)
    {
        int i = B;
        do
        {
            if (i % 2 == 0 && (i % 10 == X || i % 10 == Y))
            {
                Console.WriteLine(i);
            }
            i--;
        } while (i >= A);
    }

    static int GetInt()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число:");
            }
        }
    }

    static int GetLastDigit()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int value) && value >= 0 && value <= 9)
            {
                return value;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите цифру от 0 до 9:");
            }
        }
    }
}
