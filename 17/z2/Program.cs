using System;
using HomeApplianceLibrary;

class Program
{
    static void Main()
    {
        WashingMachine wm = new WashingMachine("Samsung", 7);
        Refrigerator fridge = new Refrigerator("LG", -5);
        Microwave microwave = new Microwave("Panasonic", 800);

        wm.TurnOn();
        fridge.TurnOn();
        microwave.TurnOn();

        wm.StartWash();
        fridge.SetTemperature(-18);
        microwave.StartCooking();

        Console.WriteLine("\nСтатусы приборов:");
        Console.WriteLine(wm.GetStatus());
        Console.WriteLine(fridge.GetStatus());
        Console.WriteLine(microwave.GetStatus());
    }
}
