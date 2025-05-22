using System; // Подключение пространства имен для базовых классов и методов
using System.Data; // Подключение пространства имен для работы с данными
using System.Windows.Forms; // Подключение пространства имен для работы с формами Windows Forms
using System.Data.SQLite; // Подключение пространства имен для работы с SQLite

namespace Task2
{
    public partial class Form1 : Form
    {
        // Конструктор формы Form1
        public Form1()
        {
            InitializeComponent(); // Инициализация компонентов формы
            LoadTourists(); // Загрузка данных туристов при инициализации формы
        }

        // Метод для создания и возвращения нового подключения к базе данных SQLite
        public SQLiteConnection CreateConnection()
        {
            string connectionString = "Data Source=../../../DBTur_firm.db;Version=3;"; // Строка подключения к базе данных
            SQLiteConnection conn = new SQLiteConnection(connectionString); // Создание нового подключения
            return conn; // Возврат созданного подключения
        }

        // Метод для загрузки данных всех туристов из базы данных
        private void LoadTourists()
        {
            using (SQLiteConnection conn = CreateConnection()) // Создание и открытие подключения к базе данных
            {
                conn.Open();
                string query = "SELECT * FROM Туристы"; // SQL-запрос для выбора всех туристов
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn); // Создание адаптера данных
                DataTable dt = new DataTable(); // Создание таблицы данных
                da.Fill(dt); // Заполнение таблицы данных
                dataGridView1.DataSource = dt; // Установка источника данных для dataGridView1

                // Очистка существующих привязок данных для текстовых полей
                textBox1.DataBindings.Clear();
                textBox2.DataBindings.Clear();
                textBox3.DataBindings.Clear();

                // Привязка текстовых полей к столбцам таблицы данных
                textBox1.DataBindings.Add("Text", dt, "Имя");
                textBox2.DataBindings.Add("Text", dt, "Фамилия");
                textBox3.DataBindings.Add("Text", dt, "Отчество");
            }
        }

        // Обработчик события нажатия кнопки для загрузки всех туров
        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = CreateConnection()) // Создание и открытие подключения к базе данных
            {
                conn.Open();
                string query = "SELECT * FROM Туры"; // SQL-запрос для выбора всех туров
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn); // Создание адаптера данных
                DataTable dt = new DataTable(); // Создание таблицы данных
                da.Fill(dt); // Заполнение таблицы данных
                dataGridView2.DataSource = dt; // Установка источника данных для dataGridView2
            }
        }

        // Обработчик события нажатия кнопки для удаления тура
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.DataSource == null) // Проверка, загружены ли данные в dataGridView2
            {
                MessageBox.Show("Сначала добавьте данные во второй DataGridView"); // Уведомление об ошибке
                return;
            }

            using (DeleteTourForm deleteForm = new DeleteTourForm()) // Создание окна для удаления тура
            {
                if (deleteForm.ShowDialog() == DialogResult.OK) // Ожидание подтверждения действия пользователем
                {
                    string tourCode = deleteForm.TourCode; // Получение кода тура для удаления

                    if (string.IsNullOrWhiteSpace(tourCode)) // Проверка, указан ли код тура
                    {
                        MessageBox.Show("Код тура не может быть пустым"); // Уведомление об ошибке
                        return;
                    }

                    using (SQLiteConnection conn = CreateConnection()) // Создание и открытие подключения к базе данных
                    {
                        conn.Open();
                        string query = "DELETE FROM Туры WHERE Код_тура = @Код_тура"; // SQL-запрос для удаления тура
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn)) // Создание SQL-команды
                        {
                            cmd.Parameters.AddWithValue("@Код_тура", tourCode); // Добавление параметра к команде
                            int rowsAffected = cmd.ExecuteNonQuery(); // Выполнение команды и получение количества затронутых строк

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Тур успешно удален"); // Уведомление об успешном удалении
                            }
                            else
                            {
                                MessageBox.Show("Тур с указанным кодом не найден"); // Уведомление об ошибке
                            }
                        }
                    }

                    button1_Click(sender, e); // Обновление списка туров
                }
            }
        }

        // Обработчик события нажатия кнопки для добавления туриста
        private void button3_Click(object sender, EventArgs e)
        {
            using (AddTouristForm addForm = new AddTouristForm()) // Создание окна для добавления туриста
            {
                if (addForm.ShowDialog() == DialogResult.OK) // Ожидание подтверждения действия пользователем
                {
                    string firstName = addForm.FirstName; // Получение имени туриста
                    string lastName = addForm.LastName; // Получение фамилии туриста
                    string middleName = addForm.MiddleName; // Получение отчества туриста

                    if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(middleName)) // Проверка, заполнены ли все поля
                    {
                        MessageBox.Show("Все поля должны быть заполнены"); // Уведомление об ошибке
                        return;
                    }

                    using (SQLiteConnection conn = CreateConnection()) // Создание и открытие подключения к базе данных
                    {
                        conn.Open();
                        string query = "INSERT INTO Туристы (Имя, Фамилия, Отчество) VALUES (@Имя, @Фамилия, @Отчество)"; // SQL-запрос для вставки нового туриста
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn)) // Создание SQL-команды
                        {
                            cmd.Parameters.AddWithValue("@Имя", firstName); // Добав
