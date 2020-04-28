using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    abstract class plane
    {
        protected double number;
        protected double length;
        protected double power;
        public abstract void Input();
        public abstract void Output();

    }

    class fighter : plane
    {
        public override void Input()
        {
            string temp;
            Console.WriteLine("Истребитель");
            Console.Write("Введите мощность истребителя: ");
            temp = Console.ReadLine();
            power = Convert.ToDouble(temp);
            Console.Write("Введите количество мест в истребителе: ");
            temp = Console.ReadLine();
            number = Convert.ToDouble(temp);
        }
        public override void Output()
        {
            Console.WriteLine("Истребитель");
            Console.WriteLine("Мощность истребителся = {0}", power);
            Console.WriteLine("Количество мест в истребителе = {0} ", number);
        }
    }

    class liner : plane
    {
        public override void Input()
        {
            string temp;
            Console.WriteLine("Лайнер ");
            Console.Write("Введите количество мест в лайнере: ");
            temp = Console.ReadLine();
            number = Convert.ToDouble(temp);
            Console.Write("Введите длину лайнера: ");
            temp = Console.ReadLine();
            length = Convert.ToDouble(temp);
        }
        public override void Output()
        {
            Console.WriteLine("Лайнер ");
            Console.WriteLine("Количество мест в лайнере = {0}", number);
            Console.WriteLine("Длина лайнера = {0}", length);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            plane obj1 = new fighter();
            plane obj2 = new liner();
            obj1.Input();
            obj2.Input();
            Console.Clear();
            obj1.Output();
            Console.WriteLine("");
            obj2.Output();
            Console.ReadLine();
        }
    }
}

