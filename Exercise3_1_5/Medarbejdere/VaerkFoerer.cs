using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejdere
{
    internal class VaerkFoerer : Mekaniker
    {
        public VaerkFoerer(string navn, string adresse, CprNr cprnr, string medarbejderNummer, DateTime svendeproeve, decimal timeloen, DateTime udnaevnt, decimal tillaeg) : base(navn, adresse, cprnr, medarbejderNummer, svendeproeve, timeloen)
        {
            this.Udnaevnt = udnaevnt;
            this.Tillaeg = tillaeg;
        }
        public DateTime Udnaevnt { get; set; }
        public decimal Tillaeg { get; set; }

        public override decimal BeregnUgeLoen()
        {
            return base.BeregnUgeLoen() + Tillaeg;
        }

    }
}
