namespace Models
{
    public class SteelFoundation : Foundation
    {
        private readonly double _loadCapacity;

        public SteelFoundation(double height, double loadCapacity) : base("Стальной фундамент", height)
        {
            _loadCapacity = loadCapacity;
        }

        public override double CalculateStrength()
        {
            return Height * _loadCapacity * 5; // Условная формула прочности
        }

        public override string GetInfo()
        {
            return $"Фундамент: {Name}, Высота = {Height:F2} м, Нагрузка = {_loadCapacity:F2}, Прочность = {CalculateStrength():F2}";
        }
    }
}
