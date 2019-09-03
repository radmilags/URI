using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1091_Divisão_da_Nlogônia
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            while (k != 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                int n = int.Parse(s[0]);
                int m = int.Parse(s[1]);
                for (int i = 1; i <= k; i++)
                {
                    string[] s1 = Console.ReadLine().Split(' ');
                    int x = int.Parse(s1[0]);
                    int y = int.Parse(s1[1]);
                    if (x == n || y == m) Console.WriteLine("divisa");
                    else if (x > n && y > m) Console.WriteLine("NE");
                    else if (x > n && y < m) Console.WriteLine("SE");
                    else if (x < n && y > m) Console.WriteLine("NO");
                    else if (x < n && y < m) Console.WriteLine("SO");
                }
                k = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
