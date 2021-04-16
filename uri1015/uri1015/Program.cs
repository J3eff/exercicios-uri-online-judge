using System;
using System.Globalization;

namespace uri1015
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.urionlinejudge.com.br/judge/pt/problems/view/1015

            string[] vet = Console.ReadLine().Split(' ');
            double x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            double x2 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
