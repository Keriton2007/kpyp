namespace Task1
{
    // Определение класса Form1, который наследует класс Form
    public partial class Form1 : Form
    {
        // Поля для хранения координат, радиуса и угла
        private int x1, y1, x2, y2, r;
        private double a;

        // Объект Pen для рисования линий
        private Pen pen = new Pen(Color.Red, 2);

        // Конструктор формы Form1
        public Form1()
        {
            InitializeComponent(); // Инициализация компонентов формы
        }

        // Обработчик события Paint, который вызывается при перерисовке формы
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Получение объекта Graphics для рисования
            Graphics g = e.Graphics;

            // Рисование линии от (x1, y1) до (x2, y2) с использованием pen
            g.DrawLine(pen, x1, y1, x2, y2);
        }

        // Обработчик события Load, который вызывается при загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            // Инициализация радиуса
            r = 150;
            // Инициализация угла
            a = 0;

            // Установка начальных координат центра линии
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;

            // Вычисление конечных координат линии на основе радиуса и угла
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
        }

        // Обработчик события Tick для таймера, который вызывается через регулярные интервалы времени
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Уменьшение угла для анимации вращения
            a -= 0.1;

            // Вычисление новых конечных координат линии на основе измененного угла
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));

            // Перерисовка формы для обновления линии
            Invalidate();
        }
    }
}
