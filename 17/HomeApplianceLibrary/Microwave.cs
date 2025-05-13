namespace HomeApplianceLibrary
{
    public class Microwave : Appliance
    {
        public int Power { get; }

        public Microwave(string brand, int power) : base(brand)
        {
            Power = power;
        }

        public void StartCooking() => Console.WriteLine($"🔥 Микроволновка {Brand} готовит еду!");

        public override string GetStatus()
        {
            return base.GetStatus() + $", Мощность: {Power} Вт";
        }
    }
}
