using System;

class Program
{
    static void Main()
    {
        int n = 7;
        int[,] matrix = new int[n, n];
        FillSpiralMatrix(matrix, n);
        PrintMatrix(matrix, n);
    }

    static void FillSpiralMatrix(int[,] matrix, int n)
    {
        int value = 1;
        int left = 0, right = n - 1, top = 0, bottom = n - 1;

        while (value <= n * n)
        {
            for (int i = left; i <= right; i++) matrix[top, i] = value++;
            top++;

            for (int i = top; i <= bottom; i++) matrix[i, right] = value++;
            right--;

            for (int i = right; i >= left; i--) matrix[bottom, i] = value++;
            bottom--;

            for (int i = bottom; i >= top; i--) matrix[i, left] = value++;
            left++;
        }
    }

    static void PrintMatrix(int[,] matrix, int n)
    {
        Console.WriteLine("Спиральная матрица 7x7:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j],3} ");
            }
            Console.WriteLine();
        }
    }
}
