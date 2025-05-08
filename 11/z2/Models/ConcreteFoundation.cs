namespace Models
{
    public class ConcreteFoundation : Foundation
    {
        private readonly double _density;

        public ConcreteFoundation(double height, double density) : base("Бетонный фундамент", height)
        {
            _density = density;
        }

        public override double CalculateStrength()
        {
            return Height * _density * 10; // Условная формула прочности
        }

        public override string GetInfo()
        {
            return $"Фундамент: {Name}, Высота = {Height:F2} м, Плотность = {_density:F2}, Прочность = {CalculateStrength():F2}";
        }
    }
}
