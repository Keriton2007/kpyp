using Models;
using Presentation;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Quadrilateral[] shapes =
            {
                new Rectangle(4, 5),
                new Square(3),
                new Rectangle(6, 2),
                new Square(5),
                new Rectangle(7, 3)
            };

            Presenter.DisplayResults(shapes);
        }
    }
}

