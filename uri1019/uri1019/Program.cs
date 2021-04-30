using System;

namespace uri1019
{
    class Program
    {
        static void Main(string[] args)
        {

            //link atividade: https://www.urionlinejudge.com.br/judge/pt/runs/code/22604051
            int n = int.Parse(Console.ReadLine());

            int hora = n / 3600;
            int minuto = (n % 3600) / 60;
            int segundo = (n % 3600) % 60;
            Console.WriteLine(hora + ":" + minuto + ":" + segundo);
        }
    }
}
