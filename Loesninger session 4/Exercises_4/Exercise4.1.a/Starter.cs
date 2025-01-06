using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Exercise4._1.a
{
    internal class Starter
    {
        delegate int Operation(int a, int b);
        static void Main(string[] args)
        {
            CalculateAndDisplay(3, 7, Add);
            CalculateAndDisplay(3,7,Multiply);

            CalculateAndDisplay(5, 25, Divide);

            CalculateAndDisplay(5, 100, (a, b) => a / b);


        }
        private static void CalculateAndDisplay(int a, int b, Operation operation)
        {
            Console.WriteLine("a:" + a + "b: " + b);
            int result = operation(a, b);
            Console.WriteLine("Result: " + result);
        }
        private static int Add(int a, int b)
        {
            return a + b;
        }
        private static int Multiply(int a, int b)
        {
            return a * b;
        }

        private static int Divide(int a, int b)
        {
            return a / b;
        }

    }

}


