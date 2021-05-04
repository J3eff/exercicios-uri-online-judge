using System;

namespace uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
            //link atividade: https://www.urionlinejudge.com.br/judge/pt/runs/code/22604505
            int idade = int.Parse(Console.ReadLine());

            int ano = idade / 365;
            int mes = (idade % 365) / 30;
            int dia = (idade % 365) % 30;

            Console.WriteLine($"{ano} ano(s)"); 
            Console.WriteLine($"{mes} mes(es)"); 
            Console.WriteLine($"{dia} dia(s)"); 
        }
    }
}
