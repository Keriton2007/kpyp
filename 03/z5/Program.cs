using System;
using System.Linq;

namespace TrainSchedule
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainStation station = new TrainStation();
        M1:
            Console.WriteLine("Выберите пункт:");
            Console.WriteLine();
            Console.WriteLine("1.Поиск поездов по пункту назначения");
            Console.WriteLine("2.Добавление поезда");
            Console.WriteLine("3.Список поездов, отправляющихся после указанного времени");
            Console.WriteLine("4.Показать все поезда");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice > 0 && choice <= 4)
            {
                switch (choice)
                {
                    case 1:
                        station.FindByDestination();
                        goto M1;
                    case 2:
                        station.AddTrain();
                        goto M1;
                    case 3:
                        station.TrainsAfterTime();
                        goto M1;
                    case 4:
                        station.PrintAll();
                        goto M1;
                }
            }
            else goto M1;
        }
    }

    class Train
    {
        public string Destination { get; set; }
        public TimeSpan DepartureTime { get; set; }

        public Train(string destination, TimeSpan departureTime)
        {
            Destination = destination;
            DepartureTime = departureTime;
        }

        
        public static bool operator >(Train t1, Train t2)
        {
            return t1.DepartureTime > t2.DepartureTime;
        }

        public static bool operator <(Train t1, Train t2)
        {
            return t1.DepartureTime < t2.DepartureTime;
        }
    }

    class TrainStation
    {
        private Train[] trains;

        public TrainStation()
        {
            trains = new Train[0];
        }

       
        public void AddTrain()
        {
            Console.WriteLine("Введите пункт назначения:");
            string destination = Console.ReadLine();

            Console.WriteLine("Введите время отправления (в формате HH:mm):");
            if (!TimeSpan.TryParse(Console.ReadLine(), out TimeSpan departureTime))
            {
                Console.WriteLine("Некорректный ввод времени!");
                return;
            }

            Array.Resize(ref trains, trains.Length + 1);
            trains[trains.Length - 1] = new Train(destination, departureTime);
        }

        
        public void FindByDestination()
        {
            Console.WriteLine("Введите пункт назначения:");
            string destination = Console.ReadLine();
            var foundTrains = trains.Where(t => t.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
                                    .OrderBy(t => t.DepartureTime);
            if (!foundTrains.Any())
            {
                Console.WriteLine("Нет поездов с таким пунктом назначения.");
            }
            else
            {
                Console.WriteLine("Поезда, отправляющиеся в " + destination + ":");
                foreach (var train in foundTrains)
                {
                    Console.WriteLine($"Пункт назначения: {train.Destination}, Время отправления: {train.DepartureTime}");
                }
            }
        }

        
        public void TrainsAfterTime()
        {
            Console.WriteLine("Введите время (в формате HH:mm):");
            if (!TimeSpan.TryParse(Console.ReadLine(), out TimeSpan time))
            {
                Console.WriteLine("Некорректный ввод времени!");
                return;
            }

            var foundTrains = trains.Where(t => t.DepartureTime > time).OrderBy(t => t.DepartureTime);
            if (!foundTrains.Any())
            {
                Console.WriteLine("Нет поездов, отправляющихся после указанного времени.");
            }
            else
            {
                Console.WriteLine("Поезда, отправляющиеся после " + time + ":");
                foreach (var train in foundTrains)
                {
                    Console.WriteLine($"Пункт назначения: {train.Destination}, Время отправления: {train.DepartureTime}");
                }
            }
        }

        
        public void PrintAll()
        {
            if (trains.Length == 0)
            {
                Console.WriteLine("Список поездов пуст.");
                return;
            }

            Console.WriteLine("Все поезда:");
            foreach (var train in trains.OrderBy(t => t.DepartureTime))
            {
                Console.WriteLine($"Пункт назначения: {train.Destination}, Время отправления: {train.DepartureTime}");
            }
        }
    }
}

