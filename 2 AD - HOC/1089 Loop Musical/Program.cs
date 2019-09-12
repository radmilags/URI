using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1089_Loop_Musical
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while(n != 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                int[] z = new int[n];
                for (int i = 0; i < s.Length; i++) z[i] = int.Parse(s[i]);

            }
        }
    }
}
