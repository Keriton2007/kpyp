using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите трёхзначное число: ");

        
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 100 && number <= 999)
        {

            int firstDigit = number / 100;          
            int secondDigit = (number / 10) % 10;   
            int thirdDigit = number % 10;          

            
            bool isAscending = firstDigit < secondDigit && secondDigit < thirdDigit;
            bool isDescending = firstDigit > secondDigit && secondDigit > thirdDigit;

            
            if (isAscending || isDescending)
            {
                Console.WriteLine($"Цифры числа {number} образуют {(isAscending ? "возрастающую" : "убывающую")} последовательность.");
            }
            else
            {
                Console.WriteLine($"Цифры числа {number} не образуют ни возрастающую, ни убывающую последовательность.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Убедитесь, что введено трёхзначное число.");
        }
    }
}
