using System;

namespace _1160_Crescimento_Populacional
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x = 0;
            for (int i = 1; i <= n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                double pa = double.Parse(s[0]);
                double pb = double.Parse(s[1]);
                double g1 = double.Parse(s[2]);
                double g2 = double.Parse(s[3]);

                while (pa < pb)
                {
                    pa *= (g1 / 100.0) + 1.0;
                    pb *= (g2 / 100.0) + 1.0;
                    x++;
                }
                if (x > 100) Console.WriteLine("Mais de 1 século.");
                else if (x <= 100) Console.WriteLine($"{x:0} anos.");
                x = 0;
            }
        }
    }
}
