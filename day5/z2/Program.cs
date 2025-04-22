using System;

class Program
{
    static void Main()
    {
        
        double[] a = new double[20];
        Console.WriteLine("Введите 20 вещественных чисел:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"a[{i + 1}] = ");
            a[i] = ReadDouble();
        }

       
        for (int i = 0; i < 10; i++)
        {
            if (a[i] > a[10 + i])
            {
                double temp = a[i];
                a[i] = temp; 
                a[10 + i] = a[10 + i]; 
            }
            else
            {
            
