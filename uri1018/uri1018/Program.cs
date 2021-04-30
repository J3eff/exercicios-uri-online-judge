using System;

namespace uri1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int nota100 = n / 100;
            int nota50 = ((n % 100) / 50);
            int nota20 = (((n % 50) % 50) / 20);
            int nota10 = ((((n % 50) % 50) % 20) / 10);
            int nota5 = (((((n % 50) % 50) % 20) % 10) / 5);
            int nota2 = ((((((n % 50) % 50) % 20) % 10) % 5) / 2);
            int nota1 = (((((((n % 50) % 50) % 20) % 10) % 5) % 2) / 1);

            Console.WriteLine(n);
            Console.WriteLine($"{nota100} nota(s) de R$ 100,00");
            Console.WriteLine($"{nota50} nota(s) de R$ 50,00");
            Console.WriteLine($"{nota20} nota(s) de R$ 20,00");
            Console.WriteLine($"{nota10} nota(s) de R$ 10,00");
            Console.WriteLine($"{nota5} nota(s) de R$ 5,00");
            Console.WriteLine($"{nota2} nota(s) de R$ 2,00");
            Console.WriteLine($"{nota1} nota(s) de R$ 1,00");
        }
    }
}
