using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medarbejdere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var medarbejderCollection = new MedarbejderListe<CprNr>();

            var morten = new Mekaniker("Morten", "Brabrand", new CprNr("211271", "7777"), "1320", new DateTime(2017, 11, 23), 195);
            var karina = new Mekaniker("Karina", "Aarhus", new CprNr("141174", "8888"), "1410", new DateTime(2019, 1, 20), 190);

            medarbejderCollection.AddElement(karina.Cprnr, karina);
            medarbejderCollection.AddElement(morten.Cprnr, morten);
            var test = medarbejderCollection.GetElement(new CprNr("211271", "7777"));
            Console.WriteLine(test);
            Console.WriteLine("Press enter");
            Console.ReadLine();

            keyMedarbejdernummer();

        }

        private static void keyMedarbejdernummer()
        {
            Console.WriteLine("Medarbejdernummer som key");
            var medarbejderCollection = new MedarbejderListe<String>();

            var morten = new Mekaniker("Morten", "Brabrand", new CprNr("211271", "7777"), "1320", new DateTime(2017, 11, 23), 195);
            var karina = new Mekaniker("Karina", "Aarhus", new CprNr("141174", "8888"), "1410", new DateTime(2019, 1, 20), 190);

            medarbejderCollection.AddElement(karina.MedarbejderNummer, karina);
            medarbejderCollection.AddElement(morten.MedarbejderNummer, morten);
            var test = medarbejderCollection.GetElement("1320");
            Console.WriteLine(test);
            Console.ReadLine();

        }
    }
}
