using System.Data; // Подключение пространства имен для работы с данными
using System.Windows; // Подключение пространства имен для работы с WPF (Windows Presentation Foundation)
using System.Data.SQLite; // Подключение пространства имен для работы с SQLite
using System.IO; // Подключение пространства имен для работы с файловой системой

namespace Task1
{
    public partial class MainWindow : Window
    {
        // Строка подключения к базе данных SQLite
        private readonly string connectionString = @"DataSource=../../../Database/DBTur_firm.db;Version=3;";

        // Конструктор главного окна
        public MainWindow()
        {
            InitializeComponent(); // Инициализация компонентов окна
            LoadAllTourists(); // Загрузка всех туристов при инициализации
        }

        // Обработчик события нажатия кнопки для загрузки всех туров
        private void SelectAllTours_Click(object sender, RoutedEventArgs e)
        {
            LoadAllTours(); // Вызов метода для загрузки всех туров
        }

        // Метод для загрузки всех туров из базы данных
        private void LoadAllTours()
        {
            // Создание и открытие подключения к базе данных
            using (SQLiteConnection connection = new(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Туры"; // SQL-запрос для выбора всех туров
                SQLiteDataAdapter adapter = new(query, connection); // Создание адаптера данных
                DataTable dataTable = new(); // Создание таблицы данных
                adapter.Fill(dataTable); // Заполнение таблицы данных
                dataGridTours.ItemsSource = dataTable.DefaultView; // Установка источника данных для элемента dataGridTours
            }
        }

        // Метод для загрузки всех туристов из базы данных
        private void LoadAllTourists()
        {
            // Создание и открытие подключения к базе данных
            using (SQLiteConnection connection = new(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Туристы"; // SQL-запрос для выбора всех туристов
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection); // Создание адаптера данных
                DataTable dataTable = new DataTable(); // Создание таблицы данных
                adapter.Fill(dataTable); // Заполнение таблицы данных
                dataGridTourists.ItemsSource = dataTable.DefaultView; // Установка источника данных для элемента dataGridTourists
            }
        }

        // Обработчик события нажатия кнопки для удаления тура
        private void DeleteTour_Click(object sender, RoutedEventArgs e)
        {
            DeleteTouristWindow deleteTouristWindow = new(); // Создание окна для удаления туриста
            if (deleteTouristWindow.ShowDialog() == true) // Ожидание подтверждения действия пользователем
            {
                int touristId = deleteTouristWindow.TourCode; // Получение кода тура для удаления
                // Создание и открытие подключения к базе данных
                using (SQLiteConnection connection = new(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Туры WHERE Код_тура = @Код_тура"; // SQL-запрос для удаления тура
                    SQLiteCommand command = new(query, connection); // Создание SQL-команды
                    command.Parameters.AddWithValue("@Код_тура", touristId); // Добавление параметра к команде
                    int rowsAffected = command.ExecuteNonQuery(); // Выполнение команды и получение количества затронутых строк
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Тур удален."); // Уведомление об успешном удалении
                    }
                    else
                    {
                        MessageBox.Show("Тур с таким кодом не найден."); // Уведомление об ошибке
                    }
                }
                LoadAllTours(); // Обновление списка туров
            }
        }

        // Обработчик события нажатия кнопки для добавления туриста
        private void AddTourist_Click(object sender, RoutedEventArgs e)
        {
            AddTouristWindow addTouristWindow = new(); // Создание окна для добавления туриста
            if (addTouristWindow.ShowDialog() == true) // Ожидание подтверждения действия пользователем
            {
                string name = addTouristWindow.Name; // Получение имени туриста
                string surname = addTouristWindow.Surname; // Получение фамилии туриста
                string middleName = addTouristWindow.MiddleName; // Получение отчества туриста

                // Создание и открытие подключения к базе данных
                using (SQLiteConnection connection = new(connectionString))
                {
                    connection.Open();
                    // SQL-запрос для вставки нового туриста
                    string query = "INSERT INTO Туристы (Фамилия, Имя, Отчество) VALUES (@Фамилия, @Имя, @Отчество)";
                    SQLiteCommand command = new SQLiteCommand(query, connection); // Создание SQL-команды
                    command.Parameters.AddWithValue("@Фамилия", surname); // Добавление параметра фамилии
                    command.Parameters.AddWithValue("@Отчество", middleName); // Добавление параметра отчества
                    command.Parameters.AddWithValue("@Имя", name); // Добавление параметра имени
                    command.ExecuteNonQuery(); // Выполнение команды
                }
                MessageBox.Show("Турист добавлен."); // Уведомление об успешном добавлении
                LoadAllTourists(); // Обновление списка туристов
            }
        }

        // Обработчик события нажатия кнопки для обновления информации о туристе
        private void UpdateTourist_Click(object sender, RoutedEventArgs e)
        {
            UpdateTouristWindow updateTouristWindow = new UpdateTouristWindow(); // Создание окна для обновления туриста
            if (updateTouristWindow.ShowDialog() == true) // Ожидание подтверждения действия пользователем
            {
                int touristId = updateTouristWindow.TouristCode; // Получение кода туриста для обновления
                string firstName = updateTouristWindow.Name; // Получение имени туриста
                string lastName = updateTouristWindow.Surname; // Получение фамилии туриста
                string patronymic = updateTouristWindow.MiddleName; // Получение отчества туриста

                // Создание и открытие подключения к базе данных
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    // SQL-запрос для обновления информации о туристе
                    string query = "UPDATE Туристы SET Фамилия = @Фамилия, Имя = @Имя, Отчество = @Отчество WHERE Код_туриста = @Код_туриста";
                    SQLiteCommand command = new SQLiteCommand(query, connection); // Создание SQL-команды
                    command.Parameters.AddWithValue("@Код_туриста", touristId); // Добавление параметра кода туриста
                    command.Parameters.AddWithValue("@Фамилия", lastName); // Добавление параметра фамилии
                    command.Parameters.AddWithValue("@Имя", firstName); // Добавление параметра имени
                    command.Parameters.AddWithValue("@Отчество", patronymic); // Добавление параметра отчества
                    int rowsAffected = command.ExecuteNonQuery(); // Выполнение команды и получение количества затронутых строк
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Турист обновлен."); // Уведомление об успешном обновлении
                    }
                    else
                    {
                        MessageBox.Show("Турист с таким кодом не найден."); // Уведомление об ошибке
                    }
                }
                LoadAllTourists(); // Обновление списка туристов
            }
        }
    }
}
