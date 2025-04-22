using System;

namespace SubModProgram
{
    class Program
    {
       
        static int SubMod(int a, int b)
        {
            return Math.Abs(a - b); 
        }

        
        static int SubMod(int a, int b, int c)
        {
            return Math.Abs(a - b - c); 
        }

        static void Main()
        {
            
            Console.WriteLine("Введите целые числа a1 и b1:");
            Console.Write("a1: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("b1: ");
            int b1 = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Введите целые числа a2, b2 и c2:");
            Console.Write("a2: ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("b2: ");
            int b2 = int.Parse(Console.ReadLine());
            Console.Write("c2: ");
            int c2 = int.Parse(Console.ReadLine());

            
            int result = SubMod(a1, b1) + SubMod(a2, b2, c2);

            
            Console.WriteLine($"Результат: SubMod(a1, b1) + SubMod(a2, b2, c2) = {result}");
        }
    }
}
