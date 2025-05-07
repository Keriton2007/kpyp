using System;
using ConsoleApplication.Models;

namespace ConsoleApplication.Presentation
{
    public class Presenter
    {
        public static void DisplayResults(Shape[] shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetInfo());
            }
        }
    }
}

