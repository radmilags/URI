using System;

namespace _1165_Número_Primo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                bool z = true;
                for (int j = 2; j < a; j++)
                    if (a % j == 0) z = false;
                if (z) Console.WriteLine($"{a} eh primo");
                else Console.WriteLine($"{a} nao eh primo");
            }
        }
    }
}
