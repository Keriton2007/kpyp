using System;

class MyList<T>
{
    private T[] items;
    private int count;

    public MyList()
    {
        items = new T[10]; 
        count = 0;
    }

    public void Add(T item)
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2);
        }
        items[count++] = item;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Индекс вне допустимого диапазона.");
            return items[index];
        }
    }

    public int Count => count;
}

class Program
{
    static void Main()
    {
        MyList<int> list = new MyList<int>();
        list.Add(5);
        list.Add(10);
        list.Add(15);

        Console.WriteLine("Элементы списка:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.WriteLine($"Общее количество элементов: {list.Count}");
    }
}
