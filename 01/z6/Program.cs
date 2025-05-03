using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер масти (1 - пики, 2 - трефы, 3 - бубны, 4 - черви): ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите номер достоинства карты (6 - 14): ");
        int k = int.Parse(Console.ReadLine());

        string suit = "";
        string rank = "";


        switch (m)
        {
            case 1:
                suit = "пик";
                break;
            case 2:
                suit = "треф";
                break;
            case 3:
                suit = "бубен";
                break;
            case 4:
                suit = "червей";
                break;
            default:
                Console.WriteLine("Некорректный номер масти!");
                return;
        }

      
        switch (k)
        {
            case 6:
                rank = "шестерка";
                break;
            case 7:
                rank = "семерка";
                break;
            case 8:
                rank = "восьмерка";
                break;
            case 9:
                rank = "девятка";
                break;
            case 10:
                rank = "десятка";
                break;
            case 11:
                rank = "валет";
                break;
            case 12:
                rank = "дама";
                break;
            case 13:
                rank = "король";
                break;
            case 14:
                rank = "туз";
                break;
            default:
                Console.WriteLine("Некорректный номер достоинства!");
                return;
        }

        Console.WriteLine($"Карта: {rank} {suit}");
    }
}
