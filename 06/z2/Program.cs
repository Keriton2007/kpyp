using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        
        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

       
        var matchingWords = words.Where(word => word.Length > 1 && char.ToLower(word.First()) == char.ToLower(word.Last()));

        Console.WriteLine("\nСлова, которые начинаются и заканчиваются одной и той же буквой:");
        foreach (var word in matchingWords)
        {
            Console.WriteLine(word);
        }
    }
}
