using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24Ckeel
{
    internal class Startclass2
    {


        public static void Main(string[] args)
        {
            double[] arvud = Osa3_funktsioonid.Tekstisy_arvud();
            var tulemus = Osa3_funktsioonid.AnalüsiArve(arvud);
            Console.WriteLine($"Summa: {tulemus.Item1:F2}, Keskmine: {tulemus.Item2:F2}, Viimane: {tulemus.Item3:F2}");
        }




            // decited to put the hard task here
            //harjudus 3
            public class Inimene
        {
            public string Nimi = "";
            public int Vanus = 0;

            public Inimene(string Nimi, int Vanus)
            {
                this.Nimi = Nimi;
                this.Vanus = Vanus;
            }

            public void PrindiAndmed()
            {
                Console.WriteLine($"Nimi: {Nimi}, Vanus: {Vanus}");
            }
        }

        public class Inimineme_func
        {
            public static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
            {
                int summa = inimesed.Sum(x => x.Vanus);
                double keskmine = inimesed.Average(x => x.Vanus);
                Inimene vanim = inimesed[0];
                Inimene noorim = inimesed[0];

                foreach (Inimene inimene in inimesed)
                {
                    if (inimene.Vanus > vanim.Vanus)
                    {
                        vanim = inimene;
                    }
                    if (inimene.Vanus < noorim.Vanus)
                    {
                        noorim = inimene;
                    }
                }

                return Tuple.Create(summa, keskmine, noorim, vanim);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                List<Inimene> inimesed = new List<Inimene>();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i + 1}. Inimene:");
                    Console.Write("Nimi: ");
                    string nimi = Console.ReadLine();
                    Console.Write("Vanus: ");
                    int vanus = int.Parse(Console.ReadLine());
                    inimesed.Add(new Inimene(nimi, vanus));
                }

                var stat = Inimineme_func.Statistika(inimesed);
                Console.WriteLine($"Vanuse summa: {stat.Item1}, Keskmine vanus: {stat.Item2:f2}");

                Console.WriteLine("Noorim inimene:");
                stat.Item3.PrindiAndmed();

                Console.WriteLine("Vanem inimene:");
                stat.Item4.PrindiAndmed();
            }
        }


    }
}


