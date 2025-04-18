using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Двузначные числа, сумма квадратов цифр которых кратна 13:");

        for (int number = 10; number < 100; number++) 
        {
            int firstDigit = number / 10;
            int secondDigit = number % 10; 


            int sumOfSquares = firstDigit * firstDigit + secondDigit * secondDigit;

            
            if (sumOfSquares % 13 == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}
