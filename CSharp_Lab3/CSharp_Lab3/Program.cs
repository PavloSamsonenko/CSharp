using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, z;
            string key;

            Console.Write("Введите один из ключей (1, first, First, FIRST, 2, Second, second, SECOND, 3, Third, third, THIRD): ");
            key = Console.ReadLine();
            Console.Write(" x= ");
            x = double.Parse(Console.ReadLine());
            switch (key)
            {
                case "1":
                case "first":
                case "First":
                case "FIRST":
                    z = Math.Pow(Math.Sin(x), 2);
                    Console.WriteLine(" z={0} ", z);
                    break;

                case "2":
                case "second":
                case "Second":
                case "SECOND":
                    if (x >= 0)
                    {
                        z = Math.Pow(Math.Log(x), 2);
                        Console.WriteLine(" z={0} ", z);
                    }
                    else
                    {
                        Console.WriteLine("Не соответсвует ОДЗ ");
                    }
                    break;
                case "3":
                case "third":
                case "Third":
                case "THIRD":
                    if (Math.Cos(Math.Pow(x, 2)) != 0)
                    {
                        z = 1 / Math.Cos(Math.Pow(x, 2));
                        Console.WriteLine(" z={0} ", z);
                    }
                    else
                    {
                        Console.WriteLine("Не соответсвует ОДЗ ");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
