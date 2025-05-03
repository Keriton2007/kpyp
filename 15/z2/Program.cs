using System;

class MyDictionary<TKey, TValue>
{
    private TKey[] keys;
    private TValue[] values;
    private int count;

    public MyDictionary()
    {
        keys = new TKey[10];
        values = new TValue[10];
        count = 0;
    }

    public void Add(TKey key, TValue value)
    {
        if (count == keys.Length)
        {
            Array.Resize(ref keys, keys.Length * 2);
            Array.Resize(ref values, values.Length * 2);
        }
        keys[count] = key;
        values[count] = value;
        count++;
    }

    public TValue this[TKey key]
    {
        get
        {
            for (int i = 0; i < count; i++)
            {
                if (keys[i].Equals(key))
                {
                    return values[i];
                }
            }
            throw new KeyNotFoundException("Ключ не найден.");
        }
    }

    public int Count => count;
}

class Program
{
    static void Main()
    {
        MyDictionary<string, int> dict = new MyDictionary<string, int>();
        dict.Add("яблоко", 5);
        dict.Add("банан", 10);
        dict.Add("вишня", 15);

        Console.WriteLine($"Количество пар: {dict.Count}");
        Console.WriteLine($"Значение по ключу 'банан': {dict["банан"]}");
    }
}
