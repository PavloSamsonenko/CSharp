using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab8
{
    class transport
    {
        protected int income;
        protected int speed;

        public virtual void Input()
        {
            Console.WriteLine("Введите чистую прибыль - ");
            income = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную скорость ");
            speed = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.WriteLine("Чистая прибыль - {0} ", income);
            Console.WriteLine("Максимальная скорость - {0}  ", speed);
        }
    }


    class vant_transport : transport
    {
        int carrying_capacity;

        public override void Input()
        {
            Console.WriteLine("Заполните информацию о грузовом транспорте");
            Console.WriteLine("Введите чистую прибыль ");
            income = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите грузоподъемность");
            carrying_capacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную скорость");
            speed = Convert.ToInt32(Console.ReadLine());
        }

        public override void Output()
        {
            Console.WriteLine("Грузовой транспорт: ");
            Console.WriteLine("Чистая прибыль - {0} ", income);
            Console.WriteLine("Грузоподъемность - {0} ", carrying_capacity);
            Console.WriteLine("Максимальная скорость- {0} ", speed);
        }
    }


    class pas_transport : transport
    {
        int amount_passengers;
        string kind;


        public override void Input()
        {
            Console.WriteLine("Заполните информацию о пассажирском траспорте");
            Console.WriteLine("Введите чистую прибыль ");
            income = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество пассажиров ");
            amount_passengers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную скорость");
            speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вид транспорта ");
            kind = Console.ReadLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            vant_transport a = new vant_transport();
            pas_transport b = new pas_transport();
            a.Input();
            a.Output();
            b.Input();
            b.Output();
            Console.ReadKey();
        }
    }
}
