using System;

namespace _1159_Soma_de_Pares_Consecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                int x = n;
                if (x % 2 != 0) x++; soma += x;
                for (int i = 1; i <= 4; i++)
                {
                    x += 2;
                    soma += x;
                }
                Console.WriteLine(soma);
                soma = 0; x = 0; n = 0;
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
