using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_4
{
    internal class Person
    {
        public Person(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }


    }
}
