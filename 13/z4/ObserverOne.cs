using System;

class ObserverOne
{
    public void ReactionOne(string message)
    {
        Console.WriteLine($"🔴 Первый наблюдатель: обработал событие – {message}");
    }

    public void ReactionTwo(string message)
    {
        Console.WriteLine($"🟡 Первый наблюдатель: дополнительный обработчик – {message}");
    }
}
