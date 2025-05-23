﻿using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "F:\\Практика кпияп\\16\\input.txt";
        string outputFile = "F:\\Практика кпияп\\16\\output.txt";

        if (!File.Exists(inputFile))
        {
            Console.WriteLine($"Файл {inputFile} не найден.");
            return;
        }

        string[] lines = File.ReadAllLines(inputFile);

        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = lines[i].Replace('0', 'X').Replace('1', '0').Replace('X', '1');
        }

        File.WriteAllLines(outputFile, lines);

        Console.WriteLine($"Файл {outputFile} успешно создан с замененными символами.");
    }
}

