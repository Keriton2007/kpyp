using System;

namespace HomeApplianceLibrary
{
    public class Microwave : Appliance
    {
        public int Power { get; }

        public Microwave(string brand, int power) : base(brand)
        {
            if (power <= 0)
                throw new ArgumentException("Ошибка: Мощность должна быть положительной!");

            Power = power;
        }

        public void StartCooking()
        {
            if (!IsOn)
            {
                Console.WriteLine("⚠️ Ошибка: Сначала включите микроволновку!");
                return;
            }

            Console.WriteLine($"🔥 Микроволновка {Brand} готовит еду!");
        }

        public override string GetStatus()
        {
            return base.GetStatus() + $", Мощность: {Power} Вт";
        }
    }
}
