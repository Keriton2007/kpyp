using System.Windows;
 // Подключение пространства имен для работы с WPF (Windows Presentation Foundation)

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для AddFlowerWindow.xaml
    /// </summary>
    public partial class AddFlowerWindow : Window
    {
        // Свойство для хранения типа цветка
        public string FlowerType { get; private set; }

        // Свойство для хранения цены цветка
        public double FlowerPrice { get; private set; }

        // Конструктор окна AddFlowerWindow
        public AddFlowerWindow()
        {
            InitializeComponent(); // Инициализация компонентов окна
        }

        // Обработчик события клика по кнопке "Добавить"
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            // Присвоить свойству FlowerType текст из текстового поля textBoxFlowerType
            FlowerType = textBoxFlowerType.Text;

            // Присвоить свойству FlowerPrice значение, преобразованное из текста текстового поля textBoxFlowerPrice
            FlowerPrice = double.Parse(textBoxFlowerPrice.Text);

            // Установить результат диалогового окна как true (означает, что действие выполнено успешно)
            DialogResult = true;

            // Закрыть окно
            Close();
        }
    }
}
