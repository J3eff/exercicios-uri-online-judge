using System;
using System.Globalization;

namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            //link da atividade: 
            //https://www.urionlinejudge.com.br/judge/pt/problems/view/1008 

            int number = int.Parse(Console.ReadLine());
            int hrsTrabalhada = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NUMBER = {0}", number);
            double sumSalary = hrsTrabalhada * salary;

            Console.WriteLine("SALARY = U$ {0}", sumSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
