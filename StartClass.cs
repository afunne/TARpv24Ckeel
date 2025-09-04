using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24Ckeel
{
    internal class StartClass
    {
        //I.Osa. Andmetüübid, Alamfunktsioon

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Tere tulemast! Mis on sinu nimi?");
            string tekst=Console.ReadLine();
            Console.WriteLine($"{tekst}, Rööm näha"); // $ is like f in python
            int a = 1000;
            char taht = 'A'; // char is for single characters
            Console.Write($"Esimene arv on {a}, Siesta b =...");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Esimene arv on {0}, Siesta {1} summa on {2}", a,b,a+b);
            Console.WriteLine("Ujukomaarv");
            double d=double.Parse(Console.ReadLine());
            Console.WriteLine(d);
            float f=float.Parse(Console.ReadLine());
            Console.WriteLine(f);
            bool t = true;

            Console.Clear();
            Console.WriteLine("welcome to the calculator :3");

            Random rnd = new Random();
            a = rnd.Next(-100, 200);
            Console.WriteLine(a);
            float vastus=Osa1_funktisoonid.Kalkulator(f,a);
            Console.WriteLine($"Kalkulaatori tulemus : {vastus}");
        }
    }
}
