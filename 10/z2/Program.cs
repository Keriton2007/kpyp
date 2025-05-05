using System;

class A
{
    private int a;
    private int b;

    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public int C => a + b; 
}

class B : A
{
    private int d;

    public B(int a, int b, int d) : base(a, b)
    {
        this.d = d;
    }

    public B(int d) : base(5, 10) 
    {
        this.d = d;
    }

    public int C2
    {
        get
        {
            if (d > 0) 
            {
                return C * d;
            }
            else
            {
                return C;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        A objA = new A(3, 7);
        B objB1 = new B(3, 7, 2);
        B objB2 = new B(4);

        Console.WriteLine($"Свойство C класса A: {objA.C}");
        Console.WriteLine($"Свойство C2 объекта B1: {objB1.C2}");
        Console.WriteLine($"Свойство C2 объекта B2: {objB2.C2}");
    }
}

