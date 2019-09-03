using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2295_Frota_de_Táxi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double g = double.Parse(s[1]);
            double ra = double.Parse(s[2]);
            double rg = double.Parse(s[3]);
            if ((a == g && ra == rg) || ra / a <= rg / g) Console.WriteLine("G");
            else Console.WriteLine("A");
            Console.ReadKey();
        }
    }
}
