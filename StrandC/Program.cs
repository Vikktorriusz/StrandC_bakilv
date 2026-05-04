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
            Console.WriteLine($"A fürdőbelépők átlagos ára: {atlag / furdok.Count}");
         


        }
    }
}
