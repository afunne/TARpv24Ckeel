using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24Ckeel
{
    internal class Osa1_funktisoonid
    {
        public static float Kalkulator(float arv1, float arv2)
        {
            float k = arv1 * arv2;
            return k;
        }
        public static string Kuu_nimetus(int kuu_nr)
        {
            string kuu = "";
            switch (kuu_nr)
            {
                case 1: kuu = "Jaanuar"; break;
                case 2: kuu = "Veebruar"; break;
                case 3: kuu = "Märts"; break;
                case 4: kuu = "Aprill"; break;
                case 5: kuu = "Mai"; break;
                case 6: kuu = "Juuni"; break;
                case 7: kuu = "Juuli"; break;
                case 8: kuu = "August"; break;
                case 9: kuu = "September"; break;
                case 10: kuu = "Oktoober"; break;
                case 11: kuu = "November"; break;
                case 12: kuu = "Detsember"; break;
                default:
                    kuu = "???"; Console.WriteLine("nuh uh");
                    break;
            }
            return kuu;
        }

        public static string Hooaeg(int kuu_nr)
        {
            string hoo = "";
            if (kuu_nr == 1 || kuu_nr == 2 || kuu_nr == 12) //&& - and. || - or
            {
                hoo = "Talv";
            }
            else if (kuu_nr > 2 && kuu_nr < 6)
            {
                hoo = "Kevad";
            }

            else if (kuu_nr > 5 && kuu_nr < 9)
            {
                hoo = "Suvi";
            }

            else if (kuu_nr > 8 && kuu_nr < 12) //9,10,11
            {
                hoo = "Sügis";
            }
            else
            {
                hoo = "???";
            }
            return hoo;
        }

        public static string KinoPilet (int aastat)
        {
            string kusi= "";
            if (aastat < 6)
            {
                kusi = "Tasuta";
            }

            else if (aastat >= 6 && aastat <= 14)
            {
                kusi = "Lastepilet";
            }

            else if (aastat >= 15 && aastat <= 65)
            {
                kusi = "täispilet";
            }

            else if (aastat >= 65 && aastat <= 100)
            {
                kusi = "sooduspilet";
            }

            else if (aastat < 0 || aastat > 100)
            {
                kusi = "viga";
            }

            else 
            {
                kusi = "thats it, Im stealing your cookies >:3";
            }
            return kusi;
        }

        public static string Pingi(string nimi1, string nimi2)
        {
            string neig = "";
            int vastunud = 0;

            if (nimi1 == "Maksim")
            {
                neig = "Ja";
            }

            else if (nimi2 == "Nikita")
            {
                neig = "Ja";
            }
            else
            {
                neig = "thats it, Im stealing your cookies >:3";
            }
            return neig;
        }

        public static float HindTrio(float a, float b)
        {
            float formula = a * b;
            return formula;
        }

        public static void CalculateRenovation()
        {
            // Küsi kõigepealt, kas remonti soovitakse
            Console.Write("Kas soovid teha põranda remonti? (jah/ei): ");
            string soov = Console.ReadLine().ToLower();

            if (soov == "jah")
            {
                // Küsi toa mõõdud
                Console.Write("Sisesta toa pikkus meetrites: ");
                double pikkus = double.Parse(Console.ReadLine());

                Console.Write("Sisesta toa laius meetrites: ");
                double laius = double.Parse(Console.ReadLine());

                // Arvuta pindala
                double pindala = pikkus * laius;
                Console.WriteLine($"Toa põranda pindala on {pindala} m².");

                // Küsi remondi hind
                Console.Write("Sisesta põranda vahetuse hind ühe ruutmeetri kohta (€): ");
                double hindRuutmeetriKohta = double.Parse(Console.ReadLine());

                double koguHind = pindala * hindRuutmeetriKohta;
                Console.WriteLine($"Põranda vahetamise kogumaksumus on {koguHind} €.");
            }
            else
            {
                Console.WriteLine("Remonti ei tehta.");
            }
        }

        // Change the access modifier of LeiaPikkuse from private to public
        public static string LeiaPikkuse(int pikkus, string sugu)
        {
            if (sugu == "mees")
            {
                if (pikkus < 165)
                {
                    return "Oled lühike mees.";
                }
                else if (pikkus <= 185)
                {
                    return "Oled keskmise pikkusega mees.";
                }
                else
                {
                    return "Oled pikk mees.";
                }
            }
            else if (sugu == "naine")
            {
                if (pikkus < 155)
                {
                    return "Oled lühike naine.";
                }
                else if (pikkus <= 175)
                {
                    return "Oled keskmise pikkusega naine.";
                }
                else
                {
                    return "Oled pikk naine.";
                }
            }
            else
            {
                return "Tundmatu sugu – ei saa võrrelda pikkust.";
            }
        }

        public static double CalculateShopping()
        {
            double total = 0;

            // Piim
            Console.Write("Kas soovid osta piima? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah")
            {
                total += 1.00;
            }

            // Sai
            Console.Write("Kas soovid osta saia? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah")
            {
                total += 0.80;
            }

            // Leib
            Console.Write("Kas soovid osta leiba? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah")
            {
                total += 1.10;
            }

            return total;
        }
    }
}
