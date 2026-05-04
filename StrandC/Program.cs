using System.Runtime.CompilerServices;

namespace StrandC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sr = File.ReadAllLines("strandadatok.txt").Skip(1).ToArray();
            List<furdo> furdok = new List<furdo>();
            foreach (string s in sr)
            {
                furdok.Add(new furdo(s));
            }
            Console.WriteLine("7.feladat:");
            Console.WriteLine($"Fürdők száma: {furdok.Count}");
            Console.WriteLine("8.feladat:");
            double atlag = 0;
            for (int i = 0; i < furdok.Count; i++)
            {
                atlag += furdok[i].ar;
            }
            Console.WriteLine($"A fürdőbelépők átlagos ára: {atlag / furdok.Count:F1}");
            Console.WriteLine("9.feladat");
            double leghidegebb = furdok[0].vizhofok;
            string leghidegebbnev = "";
            for (int i = 0; i < furdok.Count; i++)
            {
                if (furdok[i].vizhofok < leghidegebb)
                {
                    leghidegebb = furdok[i].vizhofok;
                    leghidegebbnev = furdok[i].nev;
                }
            }
            Console.WriteLine($"A leghidegebb víz a(z): {leghidegebbnev} nevű fürdőben van");
            Console.WriteLine("10.feladat");
            Console.WriteLine("Adjon meg egy fürdő nevét:");
            string nev = Console.ReadLine();
            bool van = false;
            int keresettfurdo = 0;
            for (int i = 0; i < furdok.Count; i++)
            {
                if (furdok[i].nev == nev)
                {
                    van = true;
                    keresettfurdo = i;
                }
            }
            if (van)
            {
                Console.WriteLine($"A fürdő {furdok[keresettfurdo].telepules()} településen van, az irányítószám: {furdok[keresettfurdo].IRSZ()}");

            }
            else
            {
                Console.WriteLine("Nincs ilyen nevű fürdő!");

            }
        }
    }
}
