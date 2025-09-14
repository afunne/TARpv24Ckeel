using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24Ckeel
{
    using System;
    using System.Collections.Generic;

    class Toode
    {
        public string Nimi;
        public double Kalorid100g;

        public Toode(string nimi, double kalorid)
        {
            Nimi = nimi;
            Kalorid100g = kalorid;
        }
    }

    class Inimene
    {
        public string Nimi;
        public int Vanus;
        public string Sugu;
        public double Pikkus;
        public double Kaal;
        public double Aktiivsus;

        public Inimene(string nimi, int vanus, string sugu, double pikkus, double kaal, double aktiivsus)
        {
            Nimi = nimi;
            Vanus = vanus;
            Sugu = sugu.ToLower();
            Pikkus = pikkus;
            Kaal = kaal;
            Aktiivsus = aktiivsus;
        }

        public double Energiavajadus()
        {
            double pba;
            if (Sugu == "mees")
                pba = 88.36 + (13.4 * Kaal) + (4.8 * Pikkus) - (5.7 * Vanus);
            else
                pba = 447.6 + (9.2 * Kaal) + (3.1 * Pikkus) - (4.3 * Vanus);

            return pba * Aktiivsus;
        }
    }

    class Program
    {
        static void Main()
        {
            // dude i am writing ts in 11:31pm
            // Some products
            var tooted = new List<Toode>()
        {
            new Toode("Õun", 52),
            new Toode("Banaan", 89),
            new Toode("Riis", 130)
        };

            // Get user data
            Console.Write("Nimi: ");
            string nimi = Console.ReadLine();

            Console.Write("Vanus: ");
            int vanus = int.Parse(Console.ReadLine());

            Console.Write("Sugu (mees/naine): ");
            string sugu = Console.ReadLine();

            Console.Write("Pikkus (cm): ");
            double pikkus = double.Parse(Console.ReadLine());

            Console.Write("Kaal (kg): ");
            double kaal = double.Parse(Console.ReadLine());

            Console.Write("Aktiivsus (nt 1.55): ");
            double aktiivsus = double.Parse(Console.ReadLine());

            var inimene = new Inimene(nimi, vanus, sugu, pikkus, kaal, aktiivsus);

            double vajadus = inimene.Energiavajadus();
            Console.WriteLine($"\n{nimi}, sinu päevane energiavajadus: {vajadus:F0} kcal\n");

            // Show food suggestions
            foreach (var t in tooted)
            {
                double kogus = vajadus / t.Kalorid100g * 100;
                Console.WriteLine($"{t.Nimi}: {kogus:F0} g");
            }

            // harjutus 2
            var maakonnad = new Dictionary<string, string>()
        {
            { "Harjumaa", "Tallinn" },
            { "Tartumaa", "Tartu" },
            { "Pärnumaa", "Pärnu" },
            { "Ida-Virumaa", "Jõhvi" }
        };

            while (true)
            {
                Console.WriteLine("\nVali tegevus:");
                Console.WriteLine("1. Leia pealinn maakonna järgi");
                Console.WriteLine("2. Leia maakond pealinna järgi");
                Console.WriteLine("3. Mängurežiim");
                Console.WriteLine("0. Välju");
                Console.Write("Valik: ");

                string valik = Console.ReadLine();
                if (valik == "0") break;

                if (valik == "1")
                {
                    Console.Write("Sisesta maakonna nimi: ");
                    string maakond = Console.ReadLine();

                    if (maakonnad.ContainsKey(maakond))
                        Console.WriteLine($"Pealinn: {maakonnad[maakond]}");
                    else
                    {
                        Console.WriteLine("Andmeid ei leitud. Lisa uus.");
                        Console.Write("Pealinn: ");
                        string uus = Console.ReadLine();
                        maakonnad[maakond] = uus;
                    }
                }
                else if (valik == "2")
                {
                    Console.Write("Sisesta pealinn: ");
                    string linn = Console.ReadLine();

                    string leitudMaakond = null;
                    foreach (var kv in maakonnad)
                    {
                        if (kv.Value.Equals(linn, StringComparison.OrdinalIgnoreCase))
                        {
                            leitudMaakond = kv.Key;
                            break;
                        }
                    }

                    if (leitudMaakond != null)
                        Console.WriteLine($"Maakond: {leitudMaakond}");
                    else
                    {
                        Console.WriteLine("Andmeid ei leitud. Lisa uus.");
                        Console.Write("Maakond: ");
                        string uusMaakond = Console.ReadLine();
                        maakonnad[uusMaakond] = linn;
                    }
                }
                else if (valik == "3")
                {
                    ManguReziim(maakonnad);
                }
            }
        }

        static void ManguReziim(Dictionary<string, string> maakonnad)
        {
            var rnd = new Random();
            var keys = new List<string>(maakonnad.Keys);
            int oiged = 0, kokku = 0;

            Console.WriteLine("\n--- Mäng algas! ---");
            Console.WriteLine("Sisesta tühi rida lõpetamiseks.\n");

            while (true)
            {
                // Vali juhuslikult kas küsime maakonda või pealinna
                bool kysimeMaakonna = rnd.Next(2) == 0;
                string maakond = keys[rnd.Next(keys.Count)];
                string linn = maakonnad[maakond];

                if (kysimeMaakonna)
                {
                    Console.Write($"{maakond} pealinn: ");
                    string vastus = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(vastus)) break;
                    if (vastus.Equals(linn, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Õige!");
                        oiged++;
                    }
                    else Console.WriteLine($"Vale! Õige vastus: {linn}");
                }
                else
                {
                    Console.Write($"Millise maakonna keskus on {linn}? ");
                    string vastus = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(vastus)) break;
                    if (vastus.Equals(maakond, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Õige!");
                        oiged++;
                    }
                    else Console.WriteLine($"Vale! Õige vastus: {maakond}");
                }

                kokku++;
            }

            if (kokku > 0)
            {
                double protsent = (double)oiged / kokku * 100;
                Console.WriteLine($"\nTulemus: {oiged}/{kokku} ({protsent:F1}%)");
            }
            else
            {
                Console.WriteLine("Mäng katkestati.");
            }
        }

        class Toode
        {
            public string Nimi { get; set; }
            public double Kalorid100g { get; set; }

            public Toode(string nimi, double kalorid)
            {
                Nimi = nimi;
                Kalorid100g = kalorid;
            }
        }

        class Inimene
        {
            public string Nimi;
            public int Vanus;
            public string Sugu;
            public double Pikkus;
            public double Kaal;
            public double Aktiivsus;
        

        public Inimene(string nimi, int vanus, string sugu, double pikkus, double kaal, double aktiivsus)
            {
                Nimi = nimi;
                Vanus = vanus;
                Sugu = sugu.ToLower();
                Pikkus = pikkus;
                Kaal = kaal;
                Aktiivsus = aktiivsus;
            }

            public double Energiavajadus()
            {
                double pba;
                if (Sugu == "mees")
                    pba = 88.36 + (13.4 * Kaal) + (4.8 * Pikkus) - (5.7 * Vanus);
                else
                    pba = 447.6 + (9.2 * Kaal) + (3.1 * Pikkus) - (4.3 * Vanus);

                return pba * Aktiivsus;
            }
        }

        class Program2
        {
            static void Main()
            {
                while (true)
                {
                    Console.WriteLine("\nVali ülesanne:");
                    Console.WriteLine("1. Toidud ja kalorid");
                    Console.WriteLine("2. Maakonnad ja pealinnad");
                    Console.WriteLine("0. Välju");
                    Console.Write("Valik: ");
                    string choice = Console.ReadLine();

                    if (choice == "0") break;
                    if (choice == "1") RunTask1();
                    if (choice == "2") RunTask2();
                }
            }

            // harjutus 1 
            static void RunTask1()
            {
                string file = "tooted.txt";

                // If no file, create default
                if (!File.Exists(file))
                {
                    File.WriteAllLines(file, new string[]
                    {
                "Õun;52",
                "Banaan;89",
                "Riis;130",
                "Kanafilee;165"
                    });
                }

                var tooted = new List<Toode>();
                foreach (var line in File.ReadAllLines(file))
                {
                    var parts = line.Split(';');
                    tooted.Add(new Toode(parts[0], double.Parse(parts[1])));
                }

                // Get user
                Console.Write("Nimi: ");
                string nimi = Console.ReadLine();
                Console.Write("Vanus: ");
                int vanus = int.Parse(Console.ReadLine());
                Console.Write("Sugu (mees/naine): ");
                string sugu = Console.ReadLine();
                Console.Write("Pikkus (cm): ");
                double pikkus = double.Parse(Console.ReadLine());
                Console.Write("Kaal (kg): ");
                double kaal = double.Parse(Console.ReadLine());
                Console.Write("Aktiivsus (nt 1.55): ");
                double aktiivsus = double.Parse(Console.ReadLine());

                var inimene = new Inimene(nimi, vanus, sugu, pikkus, kaal, aktiivsus);
                double vajadus = inimene.Energiavajadus();
                Console.WriteLine($"\n{nimi}, sinu päevane energiavajadus: {vajadus:F0} kcal\n");

                foreach (var t in tooted)
                {
                    double kogus = vajadus / t.Kalorid100g * 100;
                    Console.WriteLine($"{t.Nimi}: {kogus:F0} g");
                }
            }

            // harjutus 2
            static void RunTask2()
            {
                string file = "maakonnad.txt";

                if (!File.Exists(file))
                {
                    File.WriteAllLines(file, new string[]
                    {
                "Harjumaa;Tallinn",
                "Tartumaa;Tartu",
                "Pärnumaa;Pärnu"
                    });
                }

                var maakonnad = new Dictionary<string, string>();
                foreach (var line in File.ReadAllLines(file))
                {
                    var parts = line.Split(';');
                    maakonnad[parts[0]] = parts[1];
                }

                while (true)
                {
                    Console.WriteLine("\nMaakondade menüü:");
                    Console.WriteLine("1. Leia pealinn maakonna järgi");
                    Console.WriteLine("2. Leia maakond pealinna järgi");
                    Console.WriteLine("3. Mängurežiim");
                    Console.WriteLine("0. Tagasi");
                    Console.Write("Valik: ");
                    string valik = Console.ReadLine();

                    if (valik == "0")
                    {
                        // Save back to file
                        using (StreamWriter sw = new StreamWriter(file))
                        {
                            foreach (var kv in maakonnad)
                                sw.WriteLine($"{kv.Key};{kv.Value}");
                        }
                        break;
                    }

                    if (valik == "1")
                    {
                        Console.Write("Sisesta maakond: ");
                        string maakond = Console.ReadLine();
                        if (maakonnad.ContainsKey(maakond))
                            Console.WriteLine($"Pealinn: {maakonnad[maakond]}");
                        else
                        {
                            Console.WriteLine("Ei leitud. Lisa uus pealinn:");
                            string uus = Console.ReadLine();
                            maakonnad[maakond] = uus;
                        }
                    }
                    else if (valik == "2")
                    {
                        Console.Write("Sisesta pealinn: ");
                        string linn = Console.ReadLine();
                        string leitud = null;
                        foreach (var kv in maakonnad)
                        {
                            if (kv.Value.Equals(linn, StringComparison.OrdinalIgnoreCase))
                                leitud = kv.Key;
                        }
                        if (leitud != null)
                            Console.WriteLine($"Maakond: {leitud}");
                        else
                        {
                            Console.WriteLine("Ei leitud. Lisa uus maakond:");
                            string uusMaakond = Console.ReadLine();
                            maakonnad[uusMaakond] = linn;
                        }
                    }
                    else if (valik == "3")
                    {
                        QuizMode(maakonnad);
                    }
                }
            }

            static void QuizMode(Dictionary<string, string> maakonnad)
            {
                var rnd = new Random();
                var keys = new List<string>(maakonnad.Keys);
                int correct = 0, total = 0;

                Console.WriteLine("\n--- Mäng algas (tühi rida = stop) ---");
                while (true)
                {
                    bool askCounty = rnd.Next(2) == 0;
                    string county = keys[rnd.Next(keys.Count)];
                    string capital = maakonnad[county];

                    if (askCounty)
                    {
                        Console.Write($"{county} pealinn: ");
                        string ans = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(ans)) break;
                        if (ans.Equals(capital, StringComparison.OrdinalIgnoreCase)) { Console.WriteLine("Õige!"); correct++; }
                        else Console.WriteLine($"Vale! Õige oli: {capital}");
                    }
                    else
                    {
                        Console.Write($"Millise maakonna keskus on {capital}? ");
                        string ans = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(ans)) break;
                        if (ans.Equals(county, StringComparison.OrdinalIgnoreCase)) { Console.WriteLine("Õige!"); correct++; }
                        else Console.WriteLine($"Vale! Õige oli: {county}");
                    }
                    total++;
                }

                if (total > 0)
                    Console.WriteLine($"\nTulemus: {correct}/{total} ({(double)correct / total * 100:F1}%)");
            }
        }


    }

}
