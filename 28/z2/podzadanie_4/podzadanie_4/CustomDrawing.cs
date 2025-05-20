using System.Windows;
using System.Windows.Media;

namespace podzadanie_4
{
    public class CustomDrawing : FrameworkElement
    {
        protected override void OnRender(DrawingContext dc)
        {
            int size = 50; // Размер клетки
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    bool isBlack = (row + col) % 2 == 1; // Чередование цветов
                    Brush color = isBlack ? Brushes.Black : Brushes.White;

                    dc.DrawRectangle(color, new Pen(Brushes.Black, 1), new Rect(col * size, row * size, size, size));
                }
            }
        }
    }
}
