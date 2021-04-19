using System;
using System.Globalization;

namespace uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            //link: https://www.urionlinejudge.com.br/judge/pt/problems/view/1017
            int tempoGasto = int.Parse(Console.ReadLine());
            int velocidadeMedia = int.Parse(Console.ReadLine());

            double litros = tempoGasto * velocidadeMedia / 12.0;
            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
