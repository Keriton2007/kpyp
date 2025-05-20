using System.Windows;
using System.Windows.Media;

namespace zadanie_1
{
    public class CustomDrawing : FrameworkElement
    {
        protected override void OnRender(DrawingContext dc)
        {
            // Треугольник без заливки
            StreamGeometry triangleGeometry = new StreamGeometry();
            using (StreamGeometryContext ctx = triangleGeometry.Open())
            {
                ctx.BeginFigure(new Point(50, 50), true, true);
                ctx.LineTo(new Point(0, 150), true, false);
                ctx.LineTo(new Point(100, 150), true, false);
            }
            dc.DrawGeometry(null, new Pen(Brushes.Black, 2), triangleGeometry);

            // Эллипс без заливки
            dc.DrawEllipse(null, new Pen(Brushes.Black, 2), new Point(250, 100), 50, 30);

            // Закрашенный круг
            dc.DrawEllipse(Brushes.Red, new Pen(Brushes.Black, 2), new Point(400, 130), 40, 40);

            // Закрашенный прямоугольник
            dc.DrawRectangle(Brushes.Yellow, new Pen(Brushes.Black, 2), new Rect(500, 110, 120, 80));

            // Сектор (дуга)
            StreamGeometry sectorGeometry = new StreamGeometry();
            using (StreamGeometryContext ctx = sectorGeometry.Open())
            {
                ctx.BeginFigure(new Point(650, 130), true, true);
                ctx.LineTo(new Point(700, 130), true, false);
                ctx.ArcTo(new Point(650, 180), new Size(50, 50), 0, false, SweepDirection.Clockwise, true, false);
                ctx.Close();
            }
            dc.DrawGeometry(Brushes.Purple, new Pen(Brushes.Black, 2), sectorGeometry);
        }
    }
}
