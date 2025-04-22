using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();

        
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length < 3)
        {
            Console.WriteLine("Недостаточно слов для выполнения всех операций.");
            return;
        }

      
        string temp = words[0];
        words[0] = words[words.Length - 1];
        words[words.Length - 1] = temp;
        Console.WriteLine("\nПредложение после замены первого и последнего слова:");
        Console.WriteLine(string.Join(" ", words));

        
        string concatenatedWords = words[1] + words[2];
        Console.WriteLine("\nСклеенное второе и третье слово:");
        Console.WriteLine(concatenatedWords);

       
        char[] reversedWord = words[2].ToCharArray();
        Array.Reverse(reversedWord);
        Console.WriteLine("\nТретье слово в обратном порядке:");
        Console.WriteLine(new string(reversedWord));

        
        if (words[0].Length > 2)
        {
            string modifiedFirstWord = words[0].Substring(2);
            Console.WriteLine("\nПервое слово без первых двух букв:");
            Console.WriteLine(modifiedFirstWord);
        }
        else
        {
            Console.WriteLine("\nПервое слово слишком короткое, чтобы удалить две буквы.");
        }
    }
}

