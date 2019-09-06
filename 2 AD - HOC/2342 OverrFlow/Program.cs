using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2342_OverrFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            string x = s[1];
            int b = int.Parse(s[2]);
            switch (x)
            {
                case "+":
                    if (a + b <= n) Console.WriteLine("OK");
                    else Console.WriteLine("OVERFLOW");
                    break;
                case "*":
                    if (a * b <= n) Console.WriteLine("OK");
                    else Console.WriteLine("OVERFLOW");
                    break;
            }
            Console.ReadKey();
        }
    }
}
