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
            string s;
            int i, j, n, m;
            double t;
            Console.WriteLine("n: ");
            s = Console.ReadLine();
            n = Convert.ToInt32(s);
            Console.WriteLine("m: ");
            s = Console.ReadLine();
            m = Convert.ToInt32(s);
            int[] vector = new int[m];
            int[,] matr = new int[n, m];
            int[] r = new int[n];
            Console.WriteLine("Введите вектор: ");
            for(j = 0; j < m; j++)
            {
                Console.WriteLine("Вектор [{0}]: ", j + 1);
                s = Console.ReadLine();
                vector[j] = Convert.ToInt32(s);
            }
            Console.WriteLine("Введите матрицу: ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.WriteLine("Матрица [{0},{1}]: ", i + 1, j + 1);
                    s = Console.ReadLine();
                    matr[i, j] = Convert.ToInt32(s);
                }
            }
            for (i = 0; i < n; i++)
            {
                r[i] = 0;
                for (j = 0; j < m; j++)
                {
                    r[i] += matr[i, j] = vector[j];
                }
                Console.WriteLine("Результат [{0}] = {1}", i + 1, r[i]);
            }
            Console.ReadKey();
        }
    }
}