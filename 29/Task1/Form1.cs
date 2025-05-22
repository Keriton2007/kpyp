namespace Task1
{
    // ����������� ������ Form1, ������� ��������� ����� Form
    public partial class Form1 : Form
    {
        // ���� ��� �������� ���������, ������� � ����
        private int x1, y1, x2, y2, r;
        private double a;

        // ������ Pen ��� ��������� �����
        private Pen pen = new Pen(Color.Red, 2);

        // ����������� ����� Form1
        public Form1()
        {
            InitializeComponent(); // ������������� ����������� �����
        }

        // ���������� ������� Paint, ������� ���������� ��� ����������� �����
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // ��������� ������� Graphics ��� ���������
            Graphics g = e.Graphics;

            // ��������� ����� �� (x1, y1) �� (x2, y2) � �������������� pen
            g.DrawLine(pen, x1, y1, x2, y2);
        }

        // ���������� ������� Load, ������� ���������� ��� �������� �����
        private void Form1_Load(object sender, EventArgs e)
        {
            // ������������� �������
            r = 150;
            // ������������� ����
            a = 0;

            // ��������� ��������� ��������� ������ �����
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;

            // ���������� �������� ��������� ����� �� ������ ������� � ����
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
        }

        // ���������� ������� Tick ��� �������, ������� ���������� ����� ���������� ��������� �������
        private void timer1_Tick(object sender, EventArgs e)
        {
            // ���������� ���� ��� �������� ��������
            a -= 0.1;

            // ���������� ����� �������� ��������� ����� �� ������ ����������� ����
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));

            // ����������� ����� ��� ���������� �����
            Invalidate();
        }
    }
}
