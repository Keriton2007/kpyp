using System;

namespace EngineHierarchy
{
    public class Engine
    {
        string name_engine, type_engine;
        int power;

        public Engine()
        {
            this.name_engine = String.Empty;
            this.type_engine = String.Empty;
            this.power = 0;
            Input();
        }

        void Input()
        {
            Console.WriteLine("Введите название двигателя:");
            name_engine = Console.ReadLine();
            Console.WriteLine("Введите тип двигателя:");
            type_engine = Console.ReadLine();
            Console.WriteLine("Введите мощность двигателя:");
            power = Convert.ToInt32(Console.ReadLine());
        }

        public virtual string Output()
        {
            return "Название двигателя: " + name_engine + " Тип двигателя: " + type_engine + " Мощность двигателя: " + power + " ";
        }
    }

    public class InternalCombustionEngine : Engine
    {
        string fuel_type;

        public InternalCombustionEngine() : base()
        {
            this.fuel_type = String.Empty;
            Input();
        }

        void Input()
        {
            Console.WriteLine("Введите тип топлива двигателя внутреннего сгорания:");
            fuel_type = Console.ReadLine();
        }

        public override string Output()
        {
            return base.Output() + " Тип топлива: " + fuel_type + " ";
        }
    }

    public class DieselEngine : InternalCombustionEngine
    {
        int cylinder_count;

        public DieselEngine() : base()
        {
            this.cylinder_count = 0;
            Input();
        }

        void Input()
        {
            Console.WriteLine("Введите количество цилиндров дизельного двигателя:");
            cylinder_count = Convert.ToInt32(Console.ReadLine());
        }

        public override string Output()
        {
            return base.Output() + " Количество цилиндров: " + cylinder_count + " ";
        }
    }

    public class JetEngine : Engine
    {
        double thrust;

        public JetEngine() : base()
        {
            this.thrust = 0.0;
            Input();
        }

        void Input()
        {
            Console.WriteLine("Введите тягу реактивного двигателя:");
            thrust = Convert.ToDouble(Console.ReadLine());
        }

        public override string Output()
        {
            return base.Output() + " Тяга двигателя: " + thrust + " кН ";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Двигатель внутреннего сгорания:");
            InternalCombustionEngine ice = new InternalCombustionEngine();
            Console.WriteLine(ice.Output());

            Console.WriteLine("\nДизельный двигатель:");
            DieselEngine diesel = new DieselEngine();
            Console.WriteLine(diesel.Output());

            Console.WriteLine("\nРеактивный двигатель:");
            JetEngine jet = new JetEngine();
            Console.WriteLine(jet.Output());
        }
    }
}

