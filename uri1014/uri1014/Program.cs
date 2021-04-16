using System;
using System.Globalization;

namespace uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.urionlinejudge.com.br/judge/pt/problems/view/1014

            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumo = x / y;
            Console.WriteLine($"{consumo.ToString("F3", CultureInfo.InvariantCulture)} km/l");
        }
    }
}
