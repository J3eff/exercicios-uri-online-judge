using System;
using System.Globalization;

namespace uri1011
{
    class Program
    {
        static void Main(string[] args)
        {
            //Link do exercicio: https://www.urionlinejudge.com.br/judge/pt/problems/view/1011

            double pi = 3.14159;
            int r = int.Parse(Console.ReadLine());

            double volume = 4.0 / 3 * pi * Math.Pow(r, 3);

            Console.WriteLine("VOLUME = {0}", volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
