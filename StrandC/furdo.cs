using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrandC
{
    public class furdo
    {

        public string nev { get; private set; }
        public string cim { get; private set; }
        public int ar { get; private set; }

        public double vizhofok { get; private set; }

        public furdo(String sor)
        {
            string[] adatok = sor.Split(";");
            nev = adatok[0];
            cim = adatok[1];
            ar = int.Parse(adatok[2]);
            vizhofok = double.Parse(adatok[3]);
        }

        public string IRSZ()
        {
            return cim.Split(" ")[0];
        }

        public string telepules()
        {
            string seged = cim.Split(" ")[1];
            return seged = seged.Replace(",", "");
        }

    }
}
