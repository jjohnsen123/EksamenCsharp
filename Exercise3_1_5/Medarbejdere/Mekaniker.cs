using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejdere
{
    interface Person
    {
        int getTimer();
    }

    internal class Mekaniker : Medarbejder, Person
    {
        public Mekaniker(string navn, string adresse, CprNr cprnr, string medarbejderNummer, DateTime svendeproeve, decimal timeloen) : base(navn, adresse, cprnr, medarbejderNummer)
        {
            Svendeproeve = svendeproeve;
            Timeloen = timeloen;
        }

        public DateTime Svendeproeve { get; set; }
        public Decimal Timeloen { get; set; }

        // Interface
        public int getTimer()
        {
            return 10;
        }

        public override decimal BeregnUgeLoen()
        {
            return Timeloen * TimerPrUge();
        }
    }
}
