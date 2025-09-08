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
    }
}
