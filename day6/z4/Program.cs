using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите фамилию, имя и отчество:");
        string Name = Console.ReadLine().ToUpper(); 

        int code = Transcription(Name);
        Console.WriteLine($"Код личности: {code}");
    }

    static int Transcription(string Name)
    {
        
        Dictionary<char, int> letterValues = new Dictionary<char, int>()
        {
            {'А', 1}, {'Б', 2}, {'В', 3}, {'Г', 4}, {'Д', 5}, {'Е', 6}, {'Ё', 7},
            {'Ж', 8}, {'З', 9}, {'И', 10}, {'Й', 11}, {'К', 12}, {'Л', 13}, {'М', 14},
            {'Н', 15}, {'О', 16}, {'П', 17}, {'Р', 18}, {'С', 19}, {'Т', 20}, {'У', 21},
            {'Ф', 22}, {'Х', 23}, {'Ц', 24}, {'Ч', 25}, {'Ш', 26}, {'Щ', 27}, {'Ъ', 28},
            {'Ы', 29}, {'Ь', 30}, {'Э', 31}, {'Ю', 32}, {'Я', 33}
        };

       
        int sum = Name.Where(letterValues.ContainsKey).Sum(letter => letterValues[letter]);


        return ReduceToSingleDigit(sum);
    }

    
    static int ReduceToSingleDigit(int number)
    {
        if (number < 10)
        {
            return number; 
        }

        int newSum = number.ToString().Select(digit => digit - '0').Sum();
        return ReduceToSingleDigit(newSum); 
    }
}
