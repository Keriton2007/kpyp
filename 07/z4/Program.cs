using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        string pattern = @"\b[A-ZА-Я][a-zа-я]+\b";

        MatchCollection matches = Regex.Matches(input, pattern);

        Console.WriteLine("\nНайденные слова:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
