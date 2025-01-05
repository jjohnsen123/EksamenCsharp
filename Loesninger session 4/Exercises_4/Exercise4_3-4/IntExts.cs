using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_1_2
{
    internal static class IntExts
    {
        public static int Fact(this int x)
        {
            return IntUtils.Fact(x);
        }
        public static int Power(this int n, int p)
        {
            return IntUtils.Power(n, p);
        }
    }
}
