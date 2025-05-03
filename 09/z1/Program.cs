using System;

interface Ix
{
    void IxF0(double w);
    void IxF1();
}

interface Iy
{
    void F0(double w);
    void F1();
}

interface Iz
{
    void F0(double w);
    void F1();
}

class TestClass : Ix, Iy, Iz
{
    public double w;

    public TestClass(double w)
    {
        this.w = w;
    }

    
    public void IxF0(double w)
    {
        Console.WriteLine($"IxF0: {w * w}");
    }

    public void IxF1()
    {
        Console.WriteLine($"IxF1: {w + 6}");
    }

    
    public void F0(double w)
    {
        Console.WriteLine($"IyF0: {Math.Sqrt(w)}");
    }

    public void F1()
    {
        Console.WriteLine($"IyF1: {w + 2}");
    }

    
    void Iz.F0(double w)
    {
        Console.WriteLine($"IzF0: {w * w + 5}");
    }

    void Iz.F1()
    {
        Console.WriteLine($"IzF1: {w + 10}");
    }
}

class Program
{
    static void Main()
    {
        TestClass obj = new TestClass(7);

        Console.WriteLine("\nВызываем методы через объект напрямую:");
        obj.IxF0(obj.w);
        obj.IxF1();
        obj.F0(obj.w);
        obj.F1();

        Console.WriteLine("\nВызываем методы интерфейса Iz через явное приведение:");
        ((Iz)obj).F0(obj.w);
        ((Iz)obj).F1();

        Console.WriteLine("\nВызываем методы через интерфейсную ссылку:");
        Iy iyRef = obj;
        iyRef.F0(obj.w);
        iyRef.F1();
    }
}
