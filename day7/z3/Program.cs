using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        string pattern = @"\b(0[1-9]|[12]\d|3[01])/(0[1-9]|1[0-2])/\d{4}\b";

        MatchCollection matches = Regex.Matches(input, pattern);

        Console.WriteLine("\nНайденные даты:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
