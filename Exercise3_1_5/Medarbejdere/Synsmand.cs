using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejdere
{
    internal class Synsmand : Mekaniker
    {
        public Synsmand(string navn, string adresse, CprNr cprnr, string medarbejderNummer, DateTime svendeproeve, decimal timeloen, int synPrUge) : base(navn, adresse, cprnr, medarbejderNummer, svendeproeve, timeloen)
        {
            SynPrUge = synPrUge;
        }
        public int SynPrUge { get; set; }

        public override decimal BeregnUgeLoen()
        {
            return 290 * SynPrUge;
        }

    }
}
