using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Udskrift i metoden");
            Fib(4);

            Console.WriteLine("Metoden gemmer i out-param");
            int[] fibs;
            Fib(5, out fibs);
            for (int i = 0; i < fibs.Length; i++)
            {
                Console.WriteLine(fibs[i]);
            }

            Console.WriteLine("Med rekursiv metode:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(fibRecursive(i));
            }
            Console.ReadLine();
        }
        private static void Fib(int n)
        {
            int f;
            int f_1;
            int f_2;
            if (n < 1) throw new ArgumentOutOfRangeException("n", "n should be positive");
            if (n == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                f_2 = 0;
                Console.WriteLine(0);
                f_1 = 1;
                Console.WriteLine(1);
                for (int i = 3; i <= n; i++)
                {
                    f = f_1 + f_2;
                    Console.WriteLine(f);
                    f_2 = f_1;
                    f_1 = f;
                }

            }

        }
        private static void Fib(int n, out int[] result)
        {
            result = new int[n];
            int f;
            int f_1;
            int f_2;
            if (n < 1) throw new ArgumentOutOfRangeException("n", "n should be positive");
            if (n == 1)
            {
                result[0] = 0;
            }
            else
            {
                f_2 = 0;
                result[0] = 0;
                f_1 = 1;
                result[1] = 1;
                for (int i = 3; i <= n; i++)
                {
                    f = f_1 + f_2;
                    result[i - 1] = f;
                    f_2 = f_1;
                    f_1 = f;
                }

            }

        }


        private static int fibRecursive(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return fibRecursive(n - 1) + fibRecursive(n - 2);
            }
        }
    }
}
