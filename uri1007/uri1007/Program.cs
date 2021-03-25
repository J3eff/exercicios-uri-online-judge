using System;
using System.Globalization;

namespace uri1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = a * b - c * d;

            Console.WriteLine("DIFERENCA = {0}", diferenca);
        }
    }
}
