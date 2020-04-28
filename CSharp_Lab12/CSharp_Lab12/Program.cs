using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Lab12
{
    delegate double F1(double a);
    class Program
    {
        public void Input(int k, double[] f)
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write("Element[{0}]: ", i + 1);
                f[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void func(double[] f, F1 f1, F1 f2, F1 f3, int k, out double H, out double W, out double R)
        {
            H = W = R = 0;
            double s = 0, p = 1;
            for (int i = 0; i < k; i++)
                s += f[i];
            for (int i = 0; i < k; i++)
                p += f[i];
            for (int i = 0; i < k; i++)
                H += f[i] * f1(f[i]);
                H *= s;
            for (int i = 0; i < k; i++)
                W += f[i] * f2(f[i]);
                W *= p;
            for (int i = 0; i < k; i++)
                R += f[i] * f3(f[i]);
                R *= (p+s);
        }
        static void Main(string[] args)
        {
            double A, B, C, D, E, F, result;
            int n, m;
            Program obj = new Program();
            Console.Write("Enter size of first array: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter size of second array: ");
            m = Convert.ToInt32(Console.ReadLine());
            double[] x = new double[n];
            double[] y = new double[m];
            Console.WriteLine("Enter elements of array x[{0}]: ", n);
            obj.Input(n, x);
            Console.WriteLine("Enter elements of array y[{0}]: ", m);
            obj.Input(n, y);
            obj.func(x, Math.Sin, Math.Cos, Math.Tan, n, out A, out B, out C);
            obj.func(y, Math.Cos, Math.Tan, Math.Exp, m, out D, out E, out F);

            if (E != 0 && D != 0 && Math.Sin(F) != 0)
            {
                result = (A + B * Math.Cos(C)) / (D + E * Math.Sin(F));
                Console.WriteLine("Result is: {0}", result);
            }
            else
                Console.WriteLine("There is a mistake!");
                Console.ReadKey();
        }
    }
}
