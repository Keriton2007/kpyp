using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

       
        string pattern = @"\b[A-Za-z]+\b";

        MatchCollection matches = Regex.Matches(input, pattern);

        Console.WriteLine("\nСлова, содержащие только латинские буквы:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
