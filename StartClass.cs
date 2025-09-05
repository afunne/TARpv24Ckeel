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
            Random rnd = new Random();
            //2. Osa Valikud
            int kuu_number = rnd.Next(1, 12);
            string nimetus = Osa1_funktisoonid.Kuu_nimetus(kuu_number);
            Console.WriteLine($"Nr: {kuu_number}-{nimetus}");

            Console.WriteLine("Kas tahad dekooreerida arv-->nimitusse");
            string vastus = Console.ReadLine();
            if (vastus.ToLower() != "jah")
            {
                Console.WriteLine("Ei taha, siis ei taha");
            }
            else
            {
                try
                {
                    Console.Write("Nr: ");
                    kuu_number = int.Parse(Console.ReadLine());
                    Console.WriteLine(Osa1_funktisoonid.Hooaeg(kuu_number));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }

            // harjutus 1
            Console.WriteLine("Mul on amnesia aga ma arvan, et sa oled Juku. Kas ma olen õige?");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "jah" && answer.ToLower() != "ja")
            {
                Console.WriteLine("awh, 3:");
            }
            else
            {
                try
                {
                    Console.WriteLine("Kui vana sa oled? (bro think he is in disco elysium)");
                    int answer2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(Osa1_funktisoonid.KinoPilet(answer2));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            // harjutus 2
            Console.WriteLine("Mul on amnesia aga ma arvan (again), et nad on pinginaabrid? Miliseid neda nimid on?");
            string tablets0 = Console.ReadLine();
            Console.WriteLine("ja...");
            string tablets1 = Console.ReadLine();
            if (tablets0 != "Maksim" || tablets1 != "Nikita")
            {
                Console.WriteLine("Brotha, do you have amnesia as well?");
            }
            else
            {
                try
                {
                    Console.WriteLine("Oh... Tanan!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            Console.WriteLine("Yo, kas te tahate suurem ruum?");
            float priceforpetemeeter = 20;
            string BOBTHEBUILDER = Console.ReadLine();
            if (BOBTHEBUILDER != "jah")
            {
                Console.WriteLine("Ma olen väga kurb... 3_;");
            }
            else
            {
                try
                {
                    Console.WriteLine("Kui Palju?");
                    float a = float.Parse(Console.ReadLine());
                    float b = float.Parse(Console.ReadLine());
                    float formula = a*b;
                    Console.WriteLine(Osa1_funktisoonid.HindTrio(a, b));
                    Console.WriteLine($"Te peate makstaa {formula*priceforpetemeeter}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e); 
                }
            }


            //I.Osa. Andmetüübid, Alamfunktsioon
            //    Console.OutputEncoding = Encoding.UTF8;

            //    Console.BackgroundColor = ConsoleColor.Green;
            //    Console.ForegroundColor = ConsoleColor.DarkRed;

            //    Console.WriteLine("Tere tulemast! Mis on sinu nimi?");
            //    string tekst=Console.ReadLine();
            //    Console.WriteLine($"{tekst}, Rööm näha"); // $ is like f in python
            //    int a = 1000;
            //    char taht = 'A'; // char is for single characters
            //    Console.Write($"Esimene arv on {a}, Siesta b =...");
            //    int b = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Esimene arv on {0}, Siesta {1} summa on {2}", a,b,a+b);
            //    Console.WriteLine("Ujukomaarv");
            //    double d=double.Parse(Console.ReadLine());
            //    Console.WriteLine(d);
            //    float f=float.Parse(Console.ReadLine());
            //    Console.WriteLine(f);
            //    bool t = true;

            //    Console.Clear();
            //    Console.WriteLine("welcome to the calculator :3");

            //    Random rnd = new Random();
            //    a = rnd.Next(-100, 200);
            //    Console.WriteLine(a);
            //    float vastus=Osa1_funktisoonid.Kalkulator(f,a);
            //    Console.WriteLine($"Kalkulaatori tulemus : {vastus}");
        }
    }
}
