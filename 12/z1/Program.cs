using System;

class Program
{
    
    delegate double CalcFigure(double R);

    
    static double Get_Length(double R) => 2 * Math.PI * R;

   
    static double Get_Area(double R) => Math.PI * Math.Pow(R, 2);

    
    static double Get_Volume(double R) => (4.0 / 3) * Math.PI * Math.Pow(R, 3);

    static void Main()
    {
        Console.Write("Введите радиус: ");
        double radius = double.Parse(Console.ReadLine());

       
        CalcFigure CF;

        CF = Get_Length;
        Console.WriteLine($"Длина окружности: {CF(radius):F2}");

        CF = Get_Area;
        Console.WriteLine($"Площадь круга: {CF(radius):F2}");

        CF = Get_Volume;
        Console.WriteLine($"Объем шара: {CF(radius):F2}");
    }
}

