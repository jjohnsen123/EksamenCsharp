using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejdere
{
    internal class CprNr
    {
        public CprNr(string birthDate, string sequenceNumber)
        {
            BirthDate = birthDate;
            SequenceNumber = sequenceNumber;
        }

        public string BirthDate { get; set; }
        public String SequenceNumber { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is CprNr))
            {
                return false;
            }
            CprNr obj1 = (CprNr)obj;
            return BirthDate.Equals(obj1.BirthDate) && SequenceNumber.Equals(obj1.SequenceNumber);
        }
        public override int GetHashCode()
        {
            return BirthDate.GetHashCode() + SequenceNumber.GetHashCode();
        }

    }
}
