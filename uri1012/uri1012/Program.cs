using System;
using System.Globalization;

namespace uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            //Link do exercicio: https://www.urionlinejudge.com.br/judge/pt/problems/view/1012

            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double triangulo = a * c / 2;
            double circulo = 3.14159 * Math.Pow(c, 2);
            double trapezio = (a + b) * c / 2;
            double quadrado = b * b;
            double retangulo = a * b;


            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.CurrentUICulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.CurrentUICulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.CurrentUICulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.CurrentUICulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.CurrentUICulture));

        }
    }
}
