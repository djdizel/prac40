using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        delegate double Operation(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое число");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("введите первое число");
            int n = int.Parse(Console.ReadLine());
            Operation del = Average.Average1;
            Console.WriteLine(del.Invoke(m, n));
        }
    }
}
