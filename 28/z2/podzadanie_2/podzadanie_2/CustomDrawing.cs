using System.Windows;
using System.Windows.Media;

namespace podzadanie_2
{
    public class CustomDrawing : FrameworkElement
    {
        protected override void OnRender(DrawingContext dc)
        {
            // Внешний круг
            dc.DrawEllipse(null, new Pen(Brushes.Black, 2), new Point(400, 200), 100, 100);

            // Средний круг
            dc.DrawEllipse(null, new Pen(Brushes.Black, 2), new Point(400, 200), 70, 70);

            // Внутренний круг
            dc.DrawEllipse(null, new Pen(Brushes.Black, 2), new Point(400, 200), 40, 40);
        }
    }
}
