using System;

namespace HomeApplianceLibrary
{
    public class Refrigerator : Appliance
    {
        public int Temperature { get; private set; }

        public Refrigerator(string brand, int temperature) : base(brand)
        {
            if (temperature < -50 || temperature > 10)
                throw new ArgumentException("Ошибка: Температура должна быть от -50 до 10°C!");

            Temperature = temperature;
        }

        public void SetTemperature(int temp)
        {
            if (temp < -50 || temp > 10)
                throw new ArgumentException("Ошибка: Температура вне допустимого диапазона!");

            Temperature = temp;
            Console.WriteLine($"❄️ Температура установлена на {Temperature}°C");
        }

        public override string GetStatus()
        {
            return base.GetStatus() + $", Температура: {Temperature}°C";
        }
    }
}
