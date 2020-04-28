using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Lab11
{
    class Bus
    {
        string mark;
        int amount, speed;
        double price;
        public void Input(int k)
        {
            string s;
            Console.WriteLine("Bus {0}", k + 1);
            Console.Write("Enter company name of the bus: ");
            mark = Console.ReadLine();
            Console.Write("Enter amout of passangers: ");
            s = Console.ReadLine();
            amount = Convert.ToInt32(s);
            Console.Write("Enter the max speed: ");
            s = Console.ReadLine();
            speed = Convert.ToInt32(s);
            Console.Write("Enter price ot the bus: ");
            s = Console.ReadLine();
            price = Convert.ToInt32(s);
        }
        public void Output(int k)
        {
            Console.WriteLine("Bus {0}: ", k);
            Console.WriteLine("Company name {0}: ", mark);
            Console.WriteLine("Amount of passangers {0}: ", amount);
            Console.WriteLine("Max speed {0}: ", speed);
            Console.WriteLine("Price of the bus {0}: ", price);
        }
        public static bool operator ==(Bus obj1, Bus obj2)
        {
            if (obj1.mark == obj2.mark && obj1.amount == obj2.amount && obj1.speed == obj2.speed && obj1.price == obj2.price)
                return true;
            else
                return false;
        }
        public static bool operator !=(Bus obj1, Bus obj2)
        {
            if (obj1.mark != obj2.mark && obj1.amount != obj2.amount && obj1.speed != obj2.speed && obj1.price != obj2.price)
                return true;
            else
                return false;
        }
        public static bool operator <=(Bus obj1, Bus obj2)
        {
            if (obj1.price <= obj2.price)
                return true;
            else
                return false;
        }
        public static bool operator >=(Bus obj1, Bus obj2)
        {
            if (obj1.speed <= obj2.speed)
                return true;
            else
                return false;
        }
        public static double operator +(Bus obj1, Bus obj2)
        {
            return obj1.price + obj2.price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int amount;
            Console.Write("Enter amount of buses: ");
            s = Console.ReadLine();
            amount = Convert.ToInt32(s);
            Bus[] a = new Bus[amount];
            for (int i = 0; i < amount; i++)
            {
                a[i] = new Bus();
                a[i].Input(i);
            }
            for (int i = 0; i < amount - 1; i++)
            {
                Console.WriteLine("Comparison of bus {0} and {1}", i + 1, i + 2);
                Console.WriteLine("Operator == ");
                if (a[i] == a[i + 1])
                    Console.WriteLine("Bus {0} and {1} are equal", i + 1, i + 2);
                else
                    Console.WriteLine("Bus {0} and {1} are different", i + 1, i + 2);
                Console.WriteLine("Operator != ");
                if (a[i] != a[i + 1])
                    Console.WriteLine("Bus {0} and {1} are different", i + 1, i + 2);
                else
                    Console.WriteLine("Bus {0} and {1} are equal", i + 1, i + 2);
                Console.WriteLine("Operator <= ");
                if (a[i] <= a[i + 1])
                    Console.WriteLine("{0} bus costs less then bus {1}", i + 1, i + 2);
                else
                    Console.WriteLine("{0} bus costs more then bus {1}", i + 1, i + 2);
                Console.WriteLine("Operator >= ");
                if (a[i] >= a[i + 1])
                    Console.WriteLine("{0} bus is faster then bus {1}", i + 1, i + 2);
                else
                    Console.WriteLine("{0} bus is not faster then bus {1}", i + 1, i + 2);
                Console.WriteLine("Operator + ");
                Console.WriteLine("Summirized price of bus {0} and {1} is: {2}", i + 1, i + 2, a[i] + a[i + 1]);
                Console.ReadKey();
            }
        }
    }
}
