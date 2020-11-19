using System;

namespace _1197_Volta_à_Faculdade_de_Física
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            while(!string.IsNullOrEmpty(s = Console.ReadLine()))
            {
                string[] s1 = s.Split(' ');
                int v = int.Parse(s1[0]);
                int t = int.Parse(s1[1]);
                Console.WriteLine($"{v*t*2}");
            }
        }
    }
}
