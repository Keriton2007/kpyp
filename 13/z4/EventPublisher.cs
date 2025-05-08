using System;

class EventPublisher
{
    
    public delegate void EventDelegate(string message);

    public event EventDelegate EventOccurred;

    public void TriggerEvent(string message)
    {
        Console.WriteLine($"🟢 Событие вызвано: {message}");
        EventOccurred?.Invoke(message);
    }
}
