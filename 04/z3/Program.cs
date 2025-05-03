using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Введите первый набор чисел (A1, B1, C1):");
        double A1 = ReadDouble("A1");
        double B1 = ReadDouble("B1");
        double C1 = ReadDouble("C1");
        Console.WriteLine($"Первый набор до сортировки: A1={A1}, B1={B1}, C1={C1}");
        SortInc3(ref A1, ref B1, ref C1);
        Console.WriteLine($"Первый набор после сортировки: A1={A1}, B1={B1}, C1={C1}\n");

        
        Console.WriteLine("Введите второй набор чисел (A2, B2, C2):");
        double A2 = ReadDouble("A2");
        double B2 = ReadDouble("B2");
        double C2 = ReadDouble("C2");
        Console.WriteLine($"Второй набор до сортировки: A2={A2}, B2={B2}, C2={C2}");
        SortInc3(ref A2, ref B2, ref C2);
        Console.WriteLine($"Второй набор после сортировки: A2={A2}, B2={B2}, C2={C2}");
    }

    
    static void SortInc3(ref double A, ref double B, ref double C)
    {
        
        if (A > B) Swap(ref A, ref B);
        if (A > C) Swap(ref A, ref C);
        if (B > C) Swap(ref B, ref C);
    }


    static void Swap(ref double x, ref double y)
    {
        double temp = x;
        x = y;
        y = temp;
    }

    
    static double ReadDouble(string variableName)
    {
        while (true)
        {
            Console.Write($"Введите значение {variableName}: ");
            if (double.TryParse(Console.ReadLine(), out double value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите вещественное число.");
            }
        }
    }
}
