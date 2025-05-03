using System;
using System.Linq;

struct NOTE
{
    public string LastName;
    public string FirstName;
    public string PhoneNumber;
    public int[] BirthDate; 

    public void PrintInfo()
    {
        Console.WriteLine($"{LastName} {FirstName}, Телефон: {PhoneNumber}, Дата рождения: {BirthDate[0]:D2}/{BirthDate[1]:D2}/{BirthDate[2]}");
    }
}

class Program
{
    static void Main()
    {
        const int size = 8;
        NOTE[] notes = new NOTE[size];

      
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"\nВведите данные для человека {i + 1}:");

            Console.Write("Фамилия: ");
            notes[i].LastName = Console.ReadLine();

            Console.Write("Имя: ");
            notes[i].FirstName = Console.ReadLine();

            Console.Write("Номер телефона: ");
            notes[i].PhoneNumber = Console.ReadLine();

            notes[i].BirthDate = new int[3];
            Console.Write("День рождения: ");
            notes[i].BirthDate[0] = int.Parse(Console.ReadLine());

            Console.Write("Месяц рождения: ");
            notes[i].BirthDate[1] = int.Parse(Console.ReadLine());

            Console.Write("Год рождения: ");
            notes[i].BirthDate[2] = int.Parse(Console.ReadLine());
        }

       
        notes = notes.OrderBy(n => n.LastName).ThenBy(n => n.FirstName).ToArray();

        
        Console.WriteLine("\nСписок людей (по алфавиту):");
        foreach (var note in notes)
        {
            note.PrintInfo();
        }

        
        Console.Write("\nВведите месяц для поиска (1-12): ");
        int searchMonth = int.Parse(Console.ReadLine());

        var filteredNotes = notes.Where(n => n.BirthDate[1] == searchMonth).ToList();

        if (filteredNotes.Count > 0)
        {
            Console.WriteLine($"\nЛюди, родившиеся в месяце {searchMonth}:");
            foreach (var note in filteredNotes)
            {
                note.PrintInfo();
            }
        }
        else
        {
            Console.WriteLine("\nНет людей, родившихся в указанном месяце.");
        }
    }
}

