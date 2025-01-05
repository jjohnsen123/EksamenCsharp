using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejdere
{
    internal abstract class Medarbejder
    {
        public Medarbejder(string navn, string adresse, CprNr cprnr, string medarbejderNummer)
        {
            Navn = navn;
            Adresse = adresse;
            Cprnr = cprnr;
            MedarbejderNummer = medarbejderNummer;
        }

        public string Navn { get; set; }
        public String Adresse { get; set; }
        public CprNr Cprnr { get; set; }
        public String MedarbejderNummer { get; set; }
        public int TimerPrUge()
        {
            return 37;
        }
        public abstract Decimal BeregnUgeLoen();
        public override string ToString()
        {
            return "Navn:" + Navn + ", Adresse:" + Adresse + ", Cpr nummer:" + Cprnr + ", Medarbejdernummer:" + MedarbejderNummer;
        }

    }
}
