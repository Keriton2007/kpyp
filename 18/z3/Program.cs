using System;
using System.Collections.Generic;
using System.Collections;

namespace HarvestPrototype
{
    class Harvest
    {
        public string Crop { get; set; }
        public string Region { get; set; }

        public Harvest(string crop, string region)
        {
            Crop = crop;
            Region = region;
        }

        virtual public void PrintHarvest()
        {
            Console.WriteLine($"В регионе {Region} выращивается {Crop}");
        }
    }

    class Yield : Harvest
    {
        public int Amount { get; set; }

        public Yield(string crop, string region, int amount)
            : base(crop, region)
        {
            Amount = amount;
        }

        override public void PrintHarvest()
        {
            Console.WriteLine($"В регионе {Region} выращивается {Crop}, урожай составляет {Amount} тонн");
        }
    }

    class InfoObj
    {
        public static void Info<T>(T obj) where T : Harvest
        {
            obj.PrintHarvest();
        }
    }

    class HarvestCollection : IEnumerable
    {
        private List<Yield> list;

        public HarvestCollection()
        {
            list = new List<Yield>();
        }

        public void Add(Yield item)
        {
            list.Add(item);
        }

        public HarvestCollection Clone()
        {
            return new HarvestCollection { list = new List<Yield>(list) };
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < list.Count)
                list.RemoveAt(index);
        }

        public void Clear()
        {
            list.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____Пример______");
            Yield sample = new Yield("Пшеница", "Минск", 1500);
            InfoObj.Info(sample);
            Console.WriteLine("_________________");

            HarvestCollection harvestList = new HarvestCollection();
            Dictionary<int, string?> Regions = new Dictionary<int, string?>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите название урожая:");
                string crop = Console.ReadLine() ?? "Неизвестно";
                Console.WriteLine("Введите регион:");
                string region = Console.ReadLine() ?? "Неизвестно";
                Console.WriteLine("Введите количество тонн:");
                int amount;
                int.TryParse(Console.ReadLine(), out amount);

                harvestList.Add(new Yield(crop, region, amount));
                Regions[i + 1] = region;
            }

            Console.WriteLine("============");
            foreach (var entry in Regions)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }

            Console.WriteLine("============");
            foreach (Yield x in harvestList)
            {
                x.PrintHarvest();
            }

            harvestList.RemoveAt(1);
            Console.WriteLine("============");
            HarvestCollection clonedList = harvestList.Clone();
            foreach (Yield x in clonedList)
            {
                x.PrintHarvest();
            }

            Console.ReadLine();
        }
    }
}