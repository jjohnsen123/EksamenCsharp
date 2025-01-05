using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejdere
{
    internal class MedarbejderListe<TKey>
    {
        private Dictionary<TKey, Medarbejder> medarbejdere = new Dictionary<TKey, Medarbejder> ();

        public void AddElement(TKey key, Medarbejder element)
        {
            medarbejdere.Add(key, element);
        }
        public Medarbejder GetElement(TKey key)
        {
            return medarbejdere[key];
        }
        public int Size()
        {
            return medarbejdere.Count;
        }

    }
}
