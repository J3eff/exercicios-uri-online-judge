using System;

namespace uri1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaKm = int.Parse(Console.ReadLine());

            int tempo = 2 * distanciaKm;

            Console.WriteLine($"{tempo} minutos");
        }
    }
}
