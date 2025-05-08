namespace Models
{
    public class Rectangle : Quadrilateral
    {
        private readonly double _width;
        private readonly double _height;

        public Rectangle(double width, double height) : base("Прямоугольник")
        {
            _width = width;
            _height = height;
        }

        public override double CalculateArea()
        {
            return _width * _height;
        }

        public override string GetInfo()
        {
            return $"Фигура: {Name}, Ширина = {_width}, Высота = {_height}, Площадь = {CalculateArea():F2}";
        }
    }
}
