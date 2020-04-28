using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class auto
    {
        string model;
        int weight;
        int price;
        int speed;
        public void Enter(ref int n)
        {
            Console.WriteLine("Автомобиль {0}", n + 1);
            Console.Write("Введите модель автомобиля:");
            model = Console.ReadLine();
            Console.Write("Введите грузоподьемность автомобиля:");
            weight = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальную скорость автомобиля:");
            speed = int.Parse(Console.ReadLine());
            Console.Write("Введите цену автомобиля:");
            price = int.Parse(Console.ReadLine());
        }
        public void Analysis(ref int weightx, ref int pricex, ref int speedx, ref int n, ref int x)
        {
            if (speed == speedx && price <= pricex && weight == weightx)
            {
                Console.WriteLine("Автомобиль {0}", n + 1);
                Console.WriteLine("Модель: {0}", model);
                Console.WriteLine("Грузоподьемность: {0}", weight);
                Console.WriteLine("Максимальная скорость: {0}", speed);
                Console.WriteLine("Цена: {0}", price);
                x++;
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int x = 0;
            Console.Write("Введите кол-во автомобилей: ");
            n = int.Parse(Console.ReadLine());
            auto[] mas = new auto[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = new auto();
                mas[i].Enter(ref i);
            }
            Console.Clear();
            int speedx, pricex, weightx;
            Console.WriteLine("Analysis ");
            Console.Write("Введите грузоподьемность автомобиля:");
            weightx = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальную скорость автомобиля:");
            speedx = int.Parse(Console.ReadLine());
            Console.Write("Введите максимальную цену автомобиля:");
            pricex = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                mas[i].Analysis(ref weightx, ref pricex, ref speedx, ref i, ref x);
            }
            if (x <= 0)
            {
                Console.WriteLine("Подходящих автомобилей не найдено!");
            }
            Console.ReadKey();
        }
    }
}

