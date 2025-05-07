namespace ConsoleApplication.Models
{
    public abstract class Shape
    {
        protected string Name;

        protected Shape(string name)
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
