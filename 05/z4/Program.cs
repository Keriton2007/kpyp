using System;

class Program
{
    static void Main()
    {
        int rows = 20; 
        int columns = 12; 
        int[,] salaries = new int[rows, columns];


        Random random = new Random();
        Console.WriteLine("Матрица зарплат (по строкам - сотрудники, по столбцам - месяцы):");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                salaries[i, j] = random.Next(1000, 5001); 
                Console.Write(salaries[i, j] + "\t");
            }
            Console.WriteLine();
        }

        
        int februarySum = 0;
        int octoberSum = 0;

        for (int i = 0; i < rows; i++)
        {
            februarySum += salaries[i, 1]; 
            octoberSum += salaries[i, 9]; 
        }

        
        Console.WriteLine($"\nОбщая зарплата за февраль: {februarySum}");
        Console.WriteLine($"Общая зарплата за октябрь: {octoberSum}");

        if (februarySum < octoberSum)
        {
            Console.WriteLine("Да, общая зарплата всех сотрудников в феврале была меньше, чем в октябре.");
        }
        else
        {
            Console.WriteLine("Нет, общая зарплата всех сотрудников в феврале была НЕ меньше, чем в октябре.");
        }
    }
}

