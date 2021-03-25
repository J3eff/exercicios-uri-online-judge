using System;
using System.Globalization;

namespace uri1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (((2.0 * a) + 3.0 * b) + 5.0 * c) / 10.0;

            Console.WriteLine("MEDIA = {0}", media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
