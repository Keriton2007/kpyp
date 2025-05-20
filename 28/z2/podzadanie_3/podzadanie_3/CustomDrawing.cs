using System.Windows;
using System.Windows.Media;

namespace podzadanie_3
{
    public class CustomDrawing : FrameworkElement
    {
        protected override void OnRender(DrawingContext dc)
        {
            // Первый столбик
            dc.DrawRectangle(null, new Pen(Brushes.Black, 2), new Rect(50, 100, 70, 120));

            // Второй столбик
            dc.DrawRectangle(null, new Pen(Brushes.Black, 2), new Rect(100, 125, 70, 120));

            // Третий столбик
            dc.DrawRectangle(null, new Pen(Brushes.Black, 2), new Rect(150, 150, 70, 120));

            // Четвёртый столбик
            dc.DrawRectangle(null, new Pen(Brushes.Black, 2), new Rect(200, 175, 70, 120));

            // Пятый столбик
            dc.DrawRectangle(null, new Pen(Brushes.Black, 2), new Rect(250, 200, 70, 120));
        }
    }
}
