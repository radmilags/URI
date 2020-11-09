using System;

namespace _1178_Preenchimento_de_Vetor_III
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"N[{i}] = {a:0.0000}");
                a /= 2;
            }
        }
    }
}
