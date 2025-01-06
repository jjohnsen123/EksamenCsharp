using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlantEvent
{
    public delegate void Warning(int temperature);

    public class PowerPlant
    {
        // Opretter en event baseret på delegaten
        public event Warning OnWarning;

        private Random random = new Random();

        public void HeatUp()
        {
            int t = random.Next(100);
            if (t > 50)
            {
                // Udløser eventet, hvis det er tilknyttede metoder
                OnWarning?.Invoke(t);
            }
        }
    }

    internal class Program
    {
        public static List<string> warnings = new List<string>();

        static void Main(string[] args)
        {
            PowerPlant plant = new PowerPlant();

            // Tilmeld metoder til eventet
            plant.OnWarning += warningToConsole;
            plant.OnWarning += warningToSomewhereElse;

            // Simuler temperaturændringer
            for (int i = 0; i < 10; i++)
            {
                plant.HeatUp();
            }

            // Udskriv advarsler fra listen
            foreach (string warning in warnings)
            {
                Console.WriteLine(warning);
            }

            Console.ReadLine();
        }

        private static void warningToConsole(int t)
        {
            Console.WriteLine("Advarsel, temperaturen er " + t);
        }

        private static void warningToSomewhereElse(int t)
        {
            warnings.Add("Advarsel i liste på " + t + " grader");
        }
    }
}
