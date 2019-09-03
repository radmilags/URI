using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1245_Botas_Perdidas
{
    class Program
    {
        static void Main(string[] args)
        {
            //tenho que aprender mais :'(;
            int m, t; string l, s; int[] d = new int[31]; int[] e = new int[31];
            while (!string.IsNullOrEmpty(s = Console.ReadLine()))
            {
                int n = int.Parse(s); t = 0;
                for(int i = 0; i < n; i++)
                {
                    string[] s1 = Console.ReadLine().Split(' ');
                    m = int.Parse(s1[0]); l = s1[1];
                    if (l == "D") d[m]++; else e[m]++;
                }
                for (int i = 0; i < 31; i++) t += min(d[i], e[i]);
                cout << t << endl;
            }
        }
    }
}
