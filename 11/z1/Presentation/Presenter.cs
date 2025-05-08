using System;
using Models;

namespace Presentation
{
    public class Presenter
    {
        public static void DisplayResults(Quadrilateral[] shapes)
        {
            Console.WriteLine("\n--- Список фигур ---\n");

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetInfo());
            }
        }
    }
}

