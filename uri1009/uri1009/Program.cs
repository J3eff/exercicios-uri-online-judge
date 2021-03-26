using System;
using System.Globalization;

namespace uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercico: https://www.urionlinejudge.com.br/judge/pt/problems/view/1009

            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double commission = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = salary + ((commission * 15) / 100);

            Console.WriteLine("TOTAL = R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
