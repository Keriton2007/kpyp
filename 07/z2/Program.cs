using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();


        string pattern = @"\b\d+(\.\d+)?\b";

        MatchCollection matches = Regex.Matches(input, pattern);

        Console.WriteLine("\nИзвлечённые числа:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
