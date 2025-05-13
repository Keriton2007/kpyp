using System;
using System.Collections.Generic;

class Program
{
    static string ProcessString(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '#')
            {
                if (stack.Count > 0) stack.Pop(); 
            }
            else
            {
                stack.Push(c);
            }
        }

        return new string(stack.ToArray().Reverse().ToArray());
    }

    static void Main()
    {
        Console.Write("Введите строку: ");
        string userInput = Console.ReadLine();

        string result = ProcessString(userInput);
        Console.WriteLine($"Преобразованная строка: {result}");
    }
}
