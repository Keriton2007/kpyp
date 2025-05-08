using System;

class Program
{
    static void Main()
    {
        EventPublisher publisher = new EventPublisher();
        ObserverOne observer1 = new ObserverOne();
        ObserverTwo observer2 = new ObserverTwo();

       
        publisher.EventOccurred += observer1.ReactionOne;
        publisher.EventOccurred += observer1.ReactionTwo;
        publisher.EventOccurred += observer2.ReactionThree;

        Console.WriteLine("\n🔄 Вызываем событие...");
        publisher.TriggerEvent("Первое уведомление");

       
        publisher.EventOccurred -= observer1.ReactionTwo;

        Console.WriteLine("\n🔄 Вызываем событие после удаления одного обработчика...");
        publisher.TriggerEvent("Второе уведомление");
    }
}

