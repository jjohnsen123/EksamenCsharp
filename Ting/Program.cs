using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // REFERENCE VS VALUE
            // KLASSER ER REFERENCE, STRUCTS VALUE
            Person p1 = new Person() { Name = "Ole" };
            Person p2 = p1; // p2 peger nu på samme person som p1 

            p2.Name = "Alice";
            // Nu er p1.Name også "Alice", fordi p1 og p2 er referencer til samme objekt.

            Console.WriteLine($"p1 navn {p1.Name}");
            Console.WriteLine($"p2 navn {p2.Name}");

            // STRUCT
            Point a = new Point { X = 10, Y = 20 };
            Point b = a; // b er en kopi 
            b.X = 99; // Ændrer IKKE a.X // a.X er stadig 10

            Console.WriteLine($"point a = {a.X}, {a.Y}");
            Console.WriteLine($"point b = {b.X}, {b.Y}");


            // REF
            void Increase(int number)
            {
                number++;
            }

            int x = 10;
            Increase(x);
            Console.WriteLine(x);


            // Overfører en reference til den samme variabel, så ændringer slår igennem uden for metoden.
            void IncreaseWith(ref int number)
            {
                number++;
            }

            x = 10;
            IncreaseWith(ref x);
            // x = 11 efter metoden
            Console.WriteLine(x);


            // OUT
            string input = "123";

            // Minder om `ref`, men bruges oftest når en metode skal returnere mere end én værdi, eller hvis output-værdien først bliver “klargjort” i metoden.
            if (int.TryParse(input, out int result))
            {
                Console.WriteLine($"Det virkede! result = {result}");
            }
            else
            {
                Console.WriteLine("Det lykkedes ikke at parse tallet.");
            }

            // LISTE
            List<Person> people = new List<Person>();

            people.Add(new Person { Name = "Bob", Age = 30 });
            people.Add(new Person { Name = "Sara", Age = 25 });

            // Giver compile-time error, hvis du prøver at tilføje forkerte objekter

            Dog dog = new Dog();
            dog.MakeSound();
            Animal cat = new Cat();
            cat.MakeSound();



            Console.ReadLine();

        }
        class Person { public string Name; public int Age; }

        struct Point
        {
            public int X;
            public int Y;
        }

        public class Animal
        {
            public void Eat() { Console.WriteLine("Eating"); }
            public virtual void MakeSound() { Console.WriteLine("Empty"); }
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Woof");
            }
        }

        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow");
            }
        }
    }
}
