using System;

namespace _1061_Tempo_de_um_evento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leitura do inicio do evento
            string[] s = Console.ReadLine().Split(' ');
            double d = double.Parse(s[1]);
            string[] n = Console.ReadLine().Split(':');
            int h = int.Parse(n[0].Trim());
            int m = int.Parse(n[1].Trim());
            int ss = int.Parse(n[2].Trim());

            // Leitura do final do evento
            s = Console.ReadLine().Split(' ');
            double d1 = double.Parse(s[1]);
            n = Console.ReadLine().Split(':');
            int h1 = int.Parse(n[0].Trim());
            int m1 = int.Parse(n[1].Trim());
            int s1 = int.Parse(n[2].Trim());

            // Verificação
            if (s1 < ss)
            {
                while (s1 < ss)
                {
                    s1 += 60; m1--;
                }
            }
            if (m1 < m)
            {
                while (m1 < m)
                {
                    m1 += 60; h1--;
                }
            }
            if (h1 < h)
            {
                while (h1 < h)
                {
                    h1+= 24; d1--;
                }
            }

            // Subtração e saída
            Console.WriteLine($"{d1 - d} dia(s)");
            Console.WriteLine($"{h1 - h} hora(s)");
            Console.WriteLine($"{m1 - m} minuto(s)");
            Console.WriteLine($"{s1 - ss} segundo(s)");

            Console.ReadKey();
        }
    }
}
