using System;

namespace Models
{
    public abstract class Foundation
    {
        public string Name { get; }
        public double Height { get; }

        public Foundation(string name, double height)
        {
            Name = name;
            Height = height;
        }

        public abstract double CalculateStrength();

        public virtual string GetInfo()
        {
            return $"Фундамент: {Name}, Высота = {Height:F2} м, Прочность = {CalculateStrength():F2}";
        }
    }
}
