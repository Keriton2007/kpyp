using System;

namespace ДвоичныеОперации
{
    public class ДвоичноеЧисло
    {
        private string значение;

       
        public ДвоичноеЧисло(string значение)
        {
            if (ЯвляетсяДвоичным(значение))
            {
                this.значение = значение;
            }
            else
            {
                throw new ArgumentException("Строка должна содержать только двоичные символы (0 или 1).");
            }
        }

       
        private bool ЯвляетсяДвоичным(string значение)
        {
            foreach (char символ in значение)
            {
                if (символ != '0' && символ != '1')
                {
                    return false;
                }
            }
            return true;
        }

        
        public string ПолучитьЗначение()
        {
            return значение;
        }

       
        public ДвоичноеЧисло Сложить(ДвоичноеЧисло другое)
        {
            int первое = Convert.ToInt32(this.значение, 2);
            int второе = Convert.ToInt32(другое.значение, 2);
            int сумма = первое + второе;

            string результат = Convert.ToString(сумма, 2);
            return new ДвоичноеЧисло(результат);
        }

        
        public ДвоичноеЧисло Умножить(ДвоичноеЧисло другое)
        {
            int первое = Convert.ToInt32(this.значение, 2);
            int второе = Convert.ToInt32(другое.значение, 2);
            int произведение = первое * второе;

            string результат = Convert.ToString(произведение, 2);
            return new ДвоичноеЧисло(результат);
        }
    }

    class Программа
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое двоичное число:");
                ДвоичноеЧисло первоеЧисло = new ДвоичноеЧисло(Console.ReadLine());

                Console.WriteLine("Введите второе двоичное число:");
                ДвоичноеЧисло второеЧисло = new ДвоичноеЧисло(Console.ReadLine());

                ДвоичноеЧисло сумма = первоеЧисло.Сложить(второеЧисло);
                ДвоичноеЧисло произведение = первоеЧисло.Умножить(второеЧисло);

                Console.WriteLine($"Первое число: {первоеЧисло.ПолучитьЗначение()}");
                Console.WriteLine($"Второе число: {второеЧисло.ПолучитьЗначение()}");
                Console.WriteLine($"Сумма: {сумма.ПолучитьЗначение()}");
                Console.WriteLine($"Произведение: {произведение.ПолучитьЗначение()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}

