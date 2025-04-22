using System;

namespace SortProcedure
{
    class Program
    {
        static void Main()
        {
            
            double A1 = 12.5, B1 = 7.2, C1 = 9.8;
            Console.WriteLine($"Первый набор до сортировки: A1={A1}, B1={B1}, C1={C1}");
            SortDec3(ref A1, ref B1, ref C1);
            Console.WriteLine($"Первый набор после сортировки: A1={A1}, B1={B1}, C1={C1}\n");

            
            double A2 = 6.9, B2 = 18.1, C2 = 15.0;
            Console.WriteLine($"Второй набор до сортировки: A2={A2}, B2={B2}, C2={C2}");
            SortDec3(ref A2, ref B2, ref C2);
            Console.WriteLine($"Второй набор после сортировки: A2={A2}, B2={B2}, C2={C2}");
        }


        static void SortDec3(ref double A, ref double B, ref double C)
        {
            
            if (A < B) Swap(ref A, ref B);
            if (A < C) Swap(ref A, ref C);
            if (B < C) Swap(ref B, ref C);
        }

        
        static void Swap(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
        }
    }
}
