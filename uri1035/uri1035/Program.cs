using System;

namespace uri1035
{
    class Program
    {
        static void Main(string[] args)
        {
            //link da atividade: https://www.urionlinejudge.com.br/judge/pt/problems/view/1035
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);
            int d = int.Parse(vet[3]);

            if(b > c && d > a && 
                c + d > a + b &&
                c > 0 && d > 0 &&
                a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
            
        }
    }
}
