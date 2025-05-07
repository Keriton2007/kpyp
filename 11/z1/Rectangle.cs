using ConsoleApplication.Models; 
using System;

namespace z1
{
    public class Square : Shape 
    {
        private readonly double _side;

        public Square(double side) : base("Квадрат")
        {
            _side = side;
        }

        public override double CalculateArea()
        {
            return _side * _side;
        }

        public override string GetInfo()
        {
            return $"Фигура: {Name}, Сторона = {_side}, Площадь = {CalculateArea():F2}";
        }
    }
}
