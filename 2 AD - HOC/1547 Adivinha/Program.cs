using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1547_Adivinha
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int a = int.Parse(s[0]); int b = int.Parse(s[1]); int[] z = new int[a];
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < a; j++) z[j] = int.Parse(s[j]);
            }
        }
    }
}
