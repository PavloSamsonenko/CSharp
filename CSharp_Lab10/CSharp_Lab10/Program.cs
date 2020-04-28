using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            double xmin, xmax, dx, k, x, z;

            StreamReader file = new StreamReader("D:\\lab.txt");
            s = file.ReadLine();
            xmin = Convert.ToDouble(s);
            Console.WriteLine("xmin={0}", xmin);
            s = file.ReadLine();
            xmax = Convert.ToDouble(s);
            Console.WriteLine("xmax={0}", xmax);
            s = file.ReadLine();
            dx = Convert.ToDouble(s);
            Console.WriteLine("dx={0}", dx);
            s = file.ReadLine();
            k = Convert.ToDouble(s);
            Console.WriteLine("k={0}", k);
            StreamWriter sw = new StreamWriter("D:\\lab.txt");

            if (xmin + dx < xmax)
            {
                for (x = 0; x < xmax; x += dx)
                {
                    z = Math.Pow((1 / Math.Tan(k * x)), 1 / 3) + ((Math.Cos(k * x)) / Math.Log(Math.Sin(k * x)));
                    if (Math.Log(Math.Sin(k * x)) == 0 | Math.Tan(k * x) == 0 | Math.Sin(k * x) <= 0)
                    {
                        Console.WriteLine("There is a mistake!");
                        sw.WriteLine("There is a mistake!");
                    }
                    else
                    {
                        Console.WriteLine("x = {0} z = {1}", x, z);
                        sw.WriteLine("x = {0} z = {1}", x, z);
                    }
                }
            }
            else
            {
                Console.WriteLine("There is a mistake!");
                sw.Close();
                Console.ReadKey();
            }
        }
    }
}