using System;
using System.Globalization;

namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            //atividade: https://www.urionlinejudge.com.br/judge/pt/problems/view/1010

            string[] vect = Console.ReadLine().Split(' ');
            int peca1 = int.Parse(vect[0]);
            int num1 = int.Parse(vect[1]);
            double valor1 = double.Parse(vect[2], CultureInfo.InvariantCulture);

            string[] vect2 = Console.ReadLine().Split(' ');
            int peca2 = int.Parse(vect2[0]);
            int num2 = int.Parse(vect2[1]);
            double valor2 = double.Parse(vect2[2], CultureInfo.InvariantCulture);

            double sum = num1 * valor1 + num2 * valor2;

            Console.WriteLine("VALOR A PAGAR: R$ {0}", sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
