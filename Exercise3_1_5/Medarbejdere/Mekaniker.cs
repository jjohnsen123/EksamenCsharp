using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejdere
{
    internal class Mekaniker : Medarbejder
    {
        public Mekaniker(string navn, string adresse, CprNr cprnr, string medarbejderNummer, DateTime svendeproeve, decimal timeloen) : base(navn, adresse, cprnr, medarbejderNummer)
        {
            Svendeproeve = svendeproeve;
            Timeloen = timeloen;
        }

        public DateTime Svendeproeve { get; set; }
        public Decimal Timeloen { get; set; }

        public override decimal BeregnUgeLoen()
        {
            return Timeloen * TimerPrUge();
        }
    }
}
