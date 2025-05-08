using System;

namespace Models
{
    public abstract class Quadrilateral
    {
        public string Name { get; }

        protected Quadrilateral(string name)
        {
            Name = name;
        }

        public abstract double CalculateArea();

        public virtual string GetInfo()
        {
            return $"Фигура: {Name}, Площадь = {CalculateArea():F2}";
        }
    }
}

