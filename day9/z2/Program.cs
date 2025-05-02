using System;

class Vector : IComparable<Vector>
{
    private int[] data;
    private int lowerBound, upperBound;

    
    public Vector(int lowerBound, int upperBound)
    {
        if (lowerBound > upperBound)
            throw new ArgumentException("Нижняя граница не может быть больше верхней.");

        this.lowerBound = lowerBound;
        this.upperBound = upperBound;
        data = new int[upperBound - lowerBound + 1];
    }

   
    public int this[int index]
    {
        get
        {
            if (index < lowerBound || index > upperBound)
                throw new IndexOutOfRangeException("Выход за границы массива.");
            return data[index - lowerBound];
        }
        set
        {
            if (index < lowerBound || index > upperBound)
                throw new IndexOutOfRangeException("Выход за границы массива.");
            data[index - lowerBound] = value;
        }
    }

    
    public static Vector operator +(Vector v1, Vector v2)
    {
        if (v1.lowerBound != v2.lowerBound || v1.upperBound != v2.upperBound)
            throw new InvalidOperationException("Границы векторов должны совпадать.");

        Vector result = new Vector(v1.lowerBound, v1.upperBound);
        for (int i = v1.lowerBound; i <= v1.upperBound; i++)
            result[i] = v1[i] + v2[i];

        return result;
    }

   
    public static Vector operator -(Vector v1, Vector v2)
    {
        if (v1.lowerBound != v2.lowerBound || v1.upperBound != v2.upperBound)
            throw new InvalidOperationException("Границы векторов должны совпадать.");

        Vector result = new Vector(v1.lowerBound, v1.upperBound);
        for (int i = v1.lowerBound; i <= v1.upperBound; i++)
            result[i] = v1[i] - v2[i];

        return result;
    }

   
    public int CompareTo(Vector other)
    {
        int sumThis = 0, sumOther = 0;
        for (int i = lowerBound; i <= upperBound; i++) sumThis += this[i];
        for (int i = other.lowerBound; i <= other.upperBound; i++) sumOther += other[i];

        return sumThis.CompareTo(sumOther);
    }

   
    public void Print()
    {
        Console.Write("[ ");
        for (int i = lowerBound; i <= upperBound; i++)
            Console.Write(this[i] + " ");
        Console.WriteLine("]");
    }
}

class Program
{
    static void Main()
    {
        Vector v1 = new Vector(1, 5);
        Vector v2 = new Vector(1, 5);

        
        for (int i = 1; i <= 5; i++)
        {
            v1[i] = i * 2;
            v2[i] = i * 3;
        }

        Console.WriteLine("Вектор 1:");
        v1.Print();

        Console.WriteLine("Вектор 2:");
        v2.Print();

       
        Console.WriteLine("Сложение:");
        Vector sum = v1 + v2;
        sum.Print();

        Console.WriteLine("Вычитание:");
        Vector diff = v1 - v2;
        diff.Print();

        
        Console.WriteLine("\nРезультат сравнения: " + v1.CompareTo(v2));
    }
}
