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

        public static string kupislona(string märksõna)
        {
            string fraas = "";
            do
            {
                Console.WriteLine("Osta elevant ära!");
                fraas = Console.ReadLine();
            }
            while (fraas.ToLower()!=märksõna.ToLower());
            return fraas;
        }

        public static int ArvaArv()
        {
            int pandemonium = 0;
            int oinginumber = Random.Shared.Next(1, 100);
            int tries = 5;
            int õigeanw = 0;
            int newmini = 0;
            while (true)
            {
                do
                {
                    Console.WriteLine("MINIGAME!!! GUESS THE NUMBER FROM 1 TO 100");
                    pandemonium = int.Parse(Console.ReadLine());
                    if (pandemonium != oinginumber && pandemonium < oinginumber)
                    {
                        Console.WriteLine("liiga väike");
                        --tries;
                    }
                    else if (pandemonium != oinginumber && pandemonium > oinginumber)
                    {
                        Console.WriteLine("liiga suur");
                        --tries;
                    }
                    else
                    {
                        Console.WriteLine("insert a picture of a cat with thumbs up here");
                        Console.WriteLine("õige");
                        Console.Clear();
                        Console.WriteLine("uuesti? 1-ja, 0-ei");
                        newmini = int.Parse(Console.ReadLine());
                        if (newmini!=1)
                        {
                            
                        }
                        else
                        {
                            ++õigeanw;
                            Console.WriteLine("Nägemist :3");
                            break;
                        }
                    }
                }
                while (tries != 0 || õigeanw != 1);

                return pandemonium;
            }
            
        }
    }
}
