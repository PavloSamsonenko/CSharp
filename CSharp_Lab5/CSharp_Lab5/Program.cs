using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int i;
            Console.Write("Введите количество сотрудников: ");
            count = int.Parse(Console.ReadLine());

            double[] masheight = new double[count];
            double[] masweight = new double[count];
            Random random = new Random();
            for (i = 0; i < count; i++)
            {
                masheight[i] = Convert.ToDouble(random.Next(100, 200));
                masweight[i] = Convert.ToDouble(random.Next(40, 150));
            }

            foreach (int x in masheight)
            {
                Console.WriteLine("Рост сотрудника = {0} ", x);
            }
            Console.WriteLine();

            foreach (int x in masweight)
            {
                Console.WriteLine("Вес сотрудника = {0} ", x);
            }
            Console.WriteLine();

            Array.Sort(masheight, masweight);
            Console.WriteLine("Сортировка сотрудников:");
            for (i = 0; i < count; i++)
            {
                Console.WriteLine("Рост сотрудника = {0} Вес сотрудника = {1} ", masheight[i], masweight[i]);
            }

            Console.ReadKey();
        }
    }
}










