using System;

class Program
{
    static void Main()
    {
        MyInfo person = new MyInfo();
        person.NameChanged += name => Console.WriteLine($"Оповещение: имя изменено на {name}");

        Console.Write("Введите новое имя: ");
        person.Name = Console.ReadLine();
    }
}

