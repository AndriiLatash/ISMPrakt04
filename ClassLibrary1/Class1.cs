using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {

        public static double SolveTask(int A, int B)
        {


            double sum = 0, i;
            for (i = A; i <= B; i++)

                sum = sum * i;

            return sum;
        }
        public static double For2(int n)
        {
            double sum = 0, i;
            for (i = 1; i <= n; i++)
            {
                sum += 1 / i;
            }
            return sum;
        }
        public static double for3(int A, int B)
        {
            double sum = 0, i;
            for (i = A; i <= B; i++)
            {
                sum += Math.Pow(i, 2);
            }
            return sum;
        }
        public static double for5(int n) {
            double sum = 0, factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
                sum += factorial;
            }
            return sum;
            }
        public static double while1(int n)
        {
            double a = 0, b = 1, k = 1;
            double r = n;
            while (b <= n)
            {

                a += Math.Pow(b, r - k);
                k++;
                b++;

            }
            return a;
        }
        public static double while2(int n) {
            double b = 1, k = 1;
            while (b < n)
            {
                b = Math.Pow(3, k);
                k++;

            }
            return b;

            }
        public static double while3(int p)
        {
            int a = 0, s, b = 1;
            s = p / 10;
            while (a < 200)
            {
                a += 10 + s;
                b++;
            }
            return a;
        }
        public static double while4(int p)
        {
            int a = 0, s, b = 1;
            s = p / 10;
            while (a < 200)
            {
                a += 10 + s;
                b++;
            }
            return b;
        }
        public static double for4(int a, int n)
        {
            double b;
            for (b = a; b < n; b *= b)
            {


            }
            return b;
        }
    }
}

