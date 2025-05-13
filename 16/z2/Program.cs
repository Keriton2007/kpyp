using System;
using System.IO;

class Program
{
    static void Main()
    {
        string folderPath = "F:\\Практика кпияп\\16\\New_folder";
        Directory.CreateDirectory(folderPath);

        Console.WriteLine($"Папка '{folderPath}' успешно создана!");
    }
}