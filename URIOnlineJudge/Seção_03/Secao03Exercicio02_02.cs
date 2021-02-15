using System;
using System.Globalization;

// Exercícios sobre Estrutura Condicional (if-else): 02
namespace URIOnlineJudge.EstruturaCondicional
{
    class Secao03Exercicio02_02
    {
        public static void Executar()
        {
            Console.Write("Informe um numero: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("\nPar.");
            }
            else
            {
                Console.WriteLine("\nImpar.");
            }
        }
    }
}
