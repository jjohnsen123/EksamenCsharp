using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVCWithRazor.Models
{
    public class Person
    {
        public Person(string fornavn, string efternavn)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
        }

        public String Fornavn { get; set; }
        public String Efternavn { get; set; }
    }
}