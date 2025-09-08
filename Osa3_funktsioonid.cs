using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24Ckeel
{
    internal class Osa3_funktsioonid
    {
        public static int[] ArvuTöötlus(int min, int max)
        {
            Random random = new Random();
            int m = random.Next(min, max);
            int n = random.Next(min, max);
            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.WriteLine();
            int[] massive = new int[Math.Abs(m-n)+1];
            int K = 0;

            if (m < n)
            {
                for (int i = 0; i <= n; i++)
                {
                    massive[K] = i * i;
                    K++;
                }
            }

            else
            {
                for (int i = n; i <= m; i++)
                {
                    massive[K] = i * i;
                    K++;
                }
            }
            return massive;
        }

        public static double[] Tekstisy_arvud()
        {
            string sisend = Console.ReadLine();
            char[] eraldajad = new char[] {' '};

            string[] osad = sisend.Split(eraldajad, StringSplitOptions.RemoveEmptyEntries);
            double[] arvud = new double[osad.Length];
            for (int i = 0; i < osad.Length; i++)
            {
                arvud[i] = Convert.ToDouble(osad[i]);
            }
            return arvud;
        }
        public static Tuple<double, double, double> AnalüsiArve(double[] arvud)
        {
            double summa = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;
            foreach (var arv in arvud)
            {
                korrutis *= arv;
            }
            return Tuple.Create(summa, keskmine, korrutis);
        }

    }
}
