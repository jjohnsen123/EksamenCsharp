using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_1_2
{
    internal class IntUtils
    {
        public static int Fact(int x)
        {
            if (x < 0)
            {
                throw new ArgumentOutOfRangeException("x", "No negative numbers allowed");
            }
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Fact(x - 1);
            }
        }
        public static int Power(int n, int p)
        {
            return (int)Math.Pow(n, p);
        }

    }
}
