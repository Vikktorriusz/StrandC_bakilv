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

           
        }
    }
}
