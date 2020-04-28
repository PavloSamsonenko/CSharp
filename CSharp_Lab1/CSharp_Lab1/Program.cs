using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Функция 1 ");
            float c, x, a;
            Console.Write(" c= ");
            c = float.Parse(Console.ReadLine());
            Console.Write(" x= ");
            x = float.Parse(Console.ReadLine());
            Console.Write(" a= ");
            a = float.Parse(Console.ReadLine());

            float korin1 = c * x - a;
            double chis1 = Math.Log(x);
            double znam1 = Math.Log(Math.PI / 3 + x);
            double rez1 = Math.Pow(korin1, 1 / 3) + chis1 / znam1;
            if (korin1 < 0)
            {

                Console.WriteLine(" Не соответсвует ОДЗ ");

            }
            else if (x < 0)
            {

                Console.WriteLine(" Не соответсвует ОДЗ ");
            }
            else if (znam1 == 0)
            {

                Console.WriteLine(" Не соответсвует ОДЗ ");

            }
            else
            {

                Console.WriteLine("Результат первой функции: y= " + rez1);

            }

            Console.WriteLine(" Функция 2 ");

            float xmin, xmax, dx, i;
            Console.Write(" xmin = ");
            xmin = float.Parse(Console.ReadLine());
            Console.Write(" xmax = ");
            xmax = float.Parse(Console.ReadLine());
            Console.Write("dx = ");
            dx = float.Parse(Console.ReadLine());


            for (i = xmin; i <= xmax; i = i + dx)
            {

                double log2 = Math.Pow(i, 2) + 1;
                double korin2 = Math.Pow(c, 2) * Math.Pow(i, 2) + 2;
                double chis2 = Math.Log(log2);
                double znam2 = 2 * Math.PI;
                double rez2 = Math.Pow(korin2, 1 / 3) + chis2 / znam2;

                if (korin2 < 0)
                {

                    Console.WriteLine(" Не соответсвует ОДЗ ");

                }
                else if (log2 < 0)
                {

                    Console.WriteLine(" Не соответсвует ОДЗ ");
                }
                else if (znam2 == 0)
                {

                    Console.WriteLine(" Не соответсвует ОДЗ ");

                }
                else
                {

                    Console.WriteLine("Результат второй  функции(х=" + i + "): y= " + rez2);

                }
            }

            Console.WriteLine(" Функция 3 ");
            Console.WriteLine(" xmin = " + xmin);
            Console.WriteLine(" xmax = " + xmax);
            Console.WriteLine(" dx = " + dx);
            float k;
            Console.Write("k= ");
            k = float.Parse(Console.ReadLine());

            for (i = xmin; i <= xmax; i = i + dx)
            {
                double log3 = a * i;
                double korin3 = Math.Cos(a * i);
                double chis3 = k * Math.Cos(a * i);
                double znam3 = Math.Log(log3);
                double rez3 = Math.Pow(korin3, 1 / 3) + chis3 / znam3;

                if (korin3 < 0)
                {

                    Console.WriteLine(" Не соответсвует ОДЗ ");

                }
                else if (log3 < 0)
                {

                    Console.WriteLine(" Не соответсвует ОДЗ ");
                }
                else if (znam3 == 0)
                {

                    Console.WriteLine(" Не соответсвует ОДЗ ");

                }
                else
                {

                    Console.WriteLine("Результат третьей  функции(х=" + i + "): y= " + rez3);

                }

            }

            Console.ReadKey();
        }
    }
}
