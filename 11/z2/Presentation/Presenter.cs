using System;
using Models;

namespace Presentation
{
    public class Presenter
    {
        public static void DisplayResults(Foundation[] foundations)
        {
            Console.WriteLine("\n--- Список фундаментов ---\n");

            double maxHeight = 0;
            Foundation maxFoundation = null;

            foreach (var foundation in foundations)
            {
                Console.WriteLine(foundation.GetInfo());

                if (foundation.Height > maxHeight)
                {
                    maxHeight = foundation.Height;
                    maxFoundation = foundation;
                }
            }

            Console.WriteLine($"\nМаксимальная высота фундамента: {maxHeight:F2} м ({maxFoundation.Name})");
        }
    }
}
