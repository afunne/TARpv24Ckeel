using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24Ckeel
{
    internal class Isiki
    {
        public string eesnimi;
        public string perenimi= "tundmatu";
        public int synniaasta=2000;

        public Isiki() { }

        public Isiki(string eesnimi, string perenimi) 
        {
            this.eesnimi = eesnimi;
            this.perenimi = perenimi;
        }

        public void Prindi_andmed() 
        {
            Console.WriteLine($"Isiku andmed: {eesnimi} {perenimi}, Sündinud: {synniaasta}");
        }
    }
}
