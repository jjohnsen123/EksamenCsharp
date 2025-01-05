using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Ole", 37, 107));
            persons.Add(new Person("Klaus", 58, 66));
            persons.Add(new Person("Oda", 12, 42));
            persons.Add(new Person("Ib", 38, 70));
            persons.Sort(new ByAgeSorter());
            foreach (Person person in persons) {
                Console.WriteLine(person.Name + ", " + person.Age + " weighs " + person.Weight);
            }
            Console.ReadLine();
            persons.Sort((Person p1, Person p2)=> p1.Weight.CompareTo(p2.Weight));
            foreach (Person person in persons)
            {
                Console.WriteLine(person.Name + ", " + person.Age + " weighs " + person.Weight);
            }
            Console.ReadLine();
        }
    }
}
