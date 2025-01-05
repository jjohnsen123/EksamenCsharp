using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alder;
            DateTime f;
            f = new DateTime(2000, 1, 18);
            BeregnAlder(f, out alder);
            Console.WriteLine("Alder for " + f.ToString() + ": " + alder);
            f = new DateTime(2000, 1, 19);
            BeregnAlder(f, out alder);
            Console.WriteLine("Alder for " + f.ToString() + ": " + alder);
            f = new DateTime(2000, 1, 20);
            BeregnAlder(f, out alder);
            Console.WriteLine("Alder for " + f.ToString() + ": " + alder);
            f = new DateTime(2000, 2, 17);
            BeregnAlder(f, out alder);
            Console.WriteLine("Alder for " + f.ToString() + ": " + alder);

            Console.ReadLine();
        }
        private static void BeregnAlder(DateTime foedselsdag, out int alder)
        {
            int heleaar = DateTime.Now.Year - foedselsdag.Year;
            if (DateTime.Now.Month<foedselsdag.Month || (DateTime.Now.Month==foedselsdag.Month && DateTime.Now.Day<foedselsdag.Day)) {
                heleaar--;
            }
            alder = heleaar;
        }
    }
}
