using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Average
    {
        public static double Average1(int m, int n)
        {
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i;
                
            }
            return sum/(n-m+1);
        }
    }
}
