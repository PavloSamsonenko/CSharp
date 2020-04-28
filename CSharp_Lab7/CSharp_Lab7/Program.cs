using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class ship
    {
        protected string name;
        protected string function;
        protected double water;
        protected double power;
        protected string fuel;
    }
    class avia : ship
    {
        string kind;
        double number;
        public void Input1()
        {
            string s;
            Console.WriteLine("Авианосец ");
            Console.Write("Введите название авианосца: ");
            name = Console.ReadLine();
            Console.Write("Введите определение авианосца: ");
            function = Console.ReadLine();
            Console.Write("Введите водоизмещение авианосца: ");
            s = Console.ReadLine();
            water = Convert.ToDouble(s);
            Console.Write("Введите мощность двигателя: ");
            s = Console.ReadLine();
            power = Convert.ToDouble(s);
            Console.Write("Введите вид топлива: ");
            fuel = Console.ReadLine();
            Console.Write("Введите вид самолетов: ");
            kind = Console.ReadLine();
            Console.Write("Введите количество самолетов: ");
            s = Console.ReadLine();
            number = Convert.ToDouble(s);
        }
        public void Output1()
        {
            Console.WriteLine("Название: {0}", name);
            Console.WriteLine("Определение: {0}", function);
            Console.WriteLine("Водоизмещение: {0}", water);
            Console.WriteLine("Мощность двигателя: {0}", power);
            Console.WriteLine("Вид топлива: {0}", fuel);
            Console.WriteLine("Вид самолетов: {0}", kind);
            Console.WriteLine("Количество самолетов: {0}", number);
        }
    }

    class rocket : ship
    {
        string rockKind;
        double rockNumber;
        public void Input2()
        {
            string s;
            Console.WriteLine("Ракетоносец: ");
            Console.Write("Введите название ракетоносца: ");
            name = Console.ReadLine();
            Console.Write("Введите определение ракетоносца: ");
            function = Console.ReadLine();
            Console.Write("Введите водоизмещение ракетоносца: ");
            s = Console.ReadLine();
            water = Convert.ToDouble(s);
            Console.Write("Введите мощность двигателя: ");
            s = Console.ReadLine();
            power = Convert.ToDouble(s);
            Console.Write("Введите вид топлива: ");
            fuel = Console.ReadLine();
            Console.Write("Введите вид ракет: ");
            rockKind = Console.ReadLine();
            Console.Write("Введите количество ракет: ");
            s = Console.ReadLine();
            rockNumber = Convert.ToDouble(s);
        }
        public void Output2()
        {
            Console.WriteLine("Название: {0}", name);
            Console.WriteLine("Определение: {0}", function);
            Console.WriteLine("Водоизмещение: {0}", water);
            Console.WriteLine("Мощность двигателя: {0}", power);
            Console.WriteLine("Вид топлива: {0}", fuel);
            Console.WriteLine("Вид ракет: {0}", rockKind);
            Console.WriteLine("Количество ракет: {0}", rockNumber);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            avia obj1 = new avia();
            obj1.Input1();
            Console.WriteLine("");
            rocket obj2 = new rocket();
            obj2.Input2();
            Console.Clear();
            obj1.Output1();
            Console.WriteLine("");
            obj2.Output2();
            Console.ReadLine();
        }
    }
}


