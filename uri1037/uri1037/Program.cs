using System;
using System.Globalization;

namespace uri1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double intervalo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (intervalo < 0.0 || intervalo > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (intervalo <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (intervalo <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (intervalo <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}
