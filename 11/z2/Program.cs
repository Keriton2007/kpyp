using Models;
using Presentation;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Foundation[] foundations =
            {
                new ConcreteFoundation(2.5, 2400),
                new SteelFoundation(3.0, 500),
                new ConcreteFoundation(4.2, 2500),
                new SteelFoundation(2.8, 450),
                new ConcreteFoundation(3.5, 2300)
            };

            Presenter.DisplayResults(foundations);
        }
    }
}
