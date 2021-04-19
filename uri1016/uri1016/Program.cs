using System;

namespace uri1016
{
    class Program
    {
        static void Main(string[] args)
        {
            //link: https://www.urionlinejudge.com.br/judge/pt/problems/view/1016
            int distanciaKm = int.Parse(Console.ReadLine());

            int tempo = 2 * distanciaKm;

            Console.WriteLine($"{tempo} minutos");
        }
    }
}
