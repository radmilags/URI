using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1805_Soma_Natural
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            long n = b - a + 1;
            long x = ((a + b) * n) / 2;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
