using System;

class A
{
   
    public int a { get; set; }
    public int b { get; set; }

    
    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    
    public int CalculateSum()
    {
        return a + b;
    }

    
    public int CalculateDifference()
    {
        return a - b;
    }
}

class Program
{
    static void Main()
    {
        
        A obj = new A(10, 5);


        Console.WriteLine("Значение a: " + obj.a);
        Console.WriteLine("Значение b: " + obj.b);
        Console.WriteLine("Сумма a и b: " + obj.CalculateSum());
        Console.WriteLine("Разность a и b: " + obj.CalculateDifference());
    }
}
