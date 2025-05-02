using System;

enum Post
{
    Manager = 160,
    Engineer = 170,
    Developer = 180,
    Technician = 175,
    Operator = 165
}

class Accountant
{
    public bool AskForBonus(Post worker, int hours)
    {
        return hours > (int)worker; 
    }
}

class Program
{
    static void Main()
    {
        Accountant accountant = new Accountant();

        Console.Write("Введите должность сотрудника (Manager, Engineer, Developer, Technician, Operator): ");
        string positionInput = Console.ReadLine();

        Console.Write("Введите количество отработанных часов: ");
        int workedHours = int.Parse(Console.ReadLine());

        if (Enum.TryParse(positionInput, out Post worker))
        {
            bool bonus = accountant.AskForBonus(worker, workedHours);
            Console.WriteLine(bonus ? "Премия положена!" : "Премия не положена.");
        }
        else
        {
            Console.WriteLine("Ошибка: указанной должности нет в системе.");
        }
    }
}
