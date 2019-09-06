using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2408_Vice_Campeão
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            Array.Sort(s);
            Console.WriteLine(s[1]);
            Console.ReadKey();
        }
    }
}
