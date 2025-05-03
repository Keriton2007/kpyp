using System;

namespace ArrayOperations
{
    public class TwoDimensionalArray
    {
        private int[,] array;

        
        public TwoDimensionalArray(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                throw new ArgumentException("Количество строк и столбцов должно быть больше нуля.");
            }

            array = new int[rows, columns];
            FillArray();
        }

       
        private void FillArray()
        {
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"Элемент [{i}, {j}]: ");
                    if (!int.TryParse(Console.ReadLine(), out array[i, j]))
                    {
                        Console.WriteLine("Некорректный ввод! Установлено значение 0.");
                        array[i, j] = 0;
                    }
                }
            }
        }

        
        public void DisplayArray()
        {
            Console.WriteLine("\nВаш массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        
        public int GetProductOfPositiveElementsLessThanTen()
        {
            int product = 1;
            bool hasElements = false;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0 && array[i, j] < 10)
                    {
                        product *= array[i, j];
                        hasElements = true;
                    }
                }
            }

            return hasElements ? product : 0; 
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите размеры массива:");
                Console.Write("Количество строк: ");
                int rows = int.Parse(Console.ReadLine());
                Console.Write("Количество столбцов: ");
                int columns = int.Parse(Console.ReadLine());

                TwoDimensionalArray array = new TwoDimensionalArray(rows, columns);

                array.DisplayArray();

                int product = array.GetProductOfPositiveElementsLessThanTen();

                Console.WriteLine("\nПроизведение положительных элементов массива, меньших 10: " +
                                  (product != 0 ? product.ToString() : "Нет подходящих элементов"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
