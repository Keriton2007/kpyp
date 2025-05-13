using System;

namespace HomeApplianceLibrary
{
    public abstract class Appliance
    {
        public string Brand { get; }
        public bool IsOn { get; private set; }

        public Appliance(string brand)
        {
            Brand = brand;
            IsOn = false;
        }

        public void TurnOn() => IsOn = true;
        public void TurnOff() => IsOn = false;

        public virtual string GetStatus()
        {
            return $"Бренд: {Brand}, Статус: {(IsOn ? "Включено" : "Выключено")}";
        }
    }
}

