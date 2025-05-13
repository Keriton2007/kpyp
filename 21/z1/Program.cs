using System;
using System.Collections.Generic;

class LogProcessor
{
    private readonly Func<List<string>> _logImporter;

    public LogProcessor(Func<List<string>> logImporter)
    {
        _logImporter = logImporter;
    }

    public void ProcessLogs()
    {
        Console.WriteLine("\n Обработанные логи:");
        foreach (var logEntry in _logImporter.Invoke())
        {
            Console.WriteLine($"{logEntry}");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите источник логов:");
        Console.WriteLine("1 - Файл логов");
        Console.WriteLine("2 - Windows Event Log");
        Console.Write("Введите номер: ");

        int choice = int.Parse(Console.ReadLine());

        Func<List<string>> logSource = choice == 1
            ? () => new List<string>(System.IO.File.ReadAllLines("logs.txt"))
            : () => new List<string> { "Windows Log 1", "Windows Log 2", "Windows Log 3" };

        LogProcessor processor = new LogProcessor(logSource);
        processor.ProcessLogs();
    }
}
