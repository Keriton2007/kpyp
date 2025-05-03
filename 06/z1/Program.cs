using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите фрагмент текста:");
        string input = Console.ReadLine();

       
        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

        
        var wordsWithNumbers = words.Where(word => word.Any(char.IsDigit));

        Console.WriteLine("\nСлова, содержащие хотя бы одну цифру:");
        foreach (var word in wordsWithNumbers)
        {
            Console.WriteLine(word);
        }
    }
}
