using System;

class Program
{
    
    delegate string StringDelegate(string input);

    static string ReverseString(string input) => new string(input.Reverse().ToArray());

    static string ToUpperCase(string input) => input.ToUpper();

    static string ReplaceSpaces(string input) => input.Replace(" ", "_");

    static void Main()
    {
        Console.Write("Введите строку: ");
        string userInput = Console.ReadLine();


        StringDelegate del;

        del = ReverseString;
        Console.WriteLine($"Перевернутая строка: {del(userInput)}");

        del = ToUpperCase;
        Console.WriteLine($"В верхнем регистре: {del(userInput)}");

        del = ReplaceSpaces;
        Console.WriteLine($"Замена пробелов: {del(userInput)}");
    }
}
