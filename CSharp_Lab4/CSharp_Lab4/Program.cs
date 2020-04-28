using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {

        static void enter(ref int[] mas, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите [{0}] элемент массива =", i);
                mas[i] = int.Parse(Console.ReadLine());
            }

        }

        static void analysis(ref int[] mas)
        {
            int num;
            int sum = 0;
            int zero = 0;
            int mult = 1;
            bool mn = false;
            Console.Write("Введите число для сравнения с отрицательными элементами Вашего массива : ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Элементы Вашего массива, которые больше числа {0} : ", num);

            foreach (int z in mas)
            {
                if (z < 0)
                {
                    sum = sum + z;
                }

                if (z > num)
                {
                    Console.Write(z + " ");
                }

                if (z == 0)
                {
                    zero++;
                }
                if (z > 0)
                {
                    mn = true;
                    mult = mult * z;
                }
            }
            if (mn == false)
            {
                mult = 0;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Сумма отрицательных элементов Вашего массива = {0} ", sum);
            Console.WriteLine("Количество элементов Вашего массива равных нулю = {0} ", zero);
            Console.WriteLine("Произведение положительних элементов Вашего массива = {0}", mult);
        }



        static void Main(string[] args)
        {
            int amount;
            Console.Write("Введите количество элементов первого массива: ");
            amount = int.Parse(Console.ReadLine());
            int[] mas1 = new int[amount];
            enter(ref mas1, amount);
            analysis(ref mas1);

            Console.Write("Введите количество элементов второго массива: ");
            amount = int.Parse(Console.ReadLine());
            int[] mas2 = new int[amount];
            enter(ref mas2, amount);
            analysis(ref mas2);

            Console.Write("Введите количество элементов третьего массива: ");
            amount = int.Parse(Console.ReadLine());
            int[] mas3 = new int[amount];
            enter(ref mas3, amount);
            analysis(ref mas3);

            Console.ReadKey();
        }
    }
}
