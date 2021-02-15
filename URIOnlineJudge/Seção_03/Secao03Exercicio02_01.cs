using System;
using System.Globalization;

// Exercícios sobre Estrutura Condicional (if-else): 01
namespace URIOnlineJudge.EstruturaCondicional
{
    class Secao03Exercicio02_01
    {
        public static void Executar()
        {
            Console.Write("Informe um numero: ");
            int NUM = int.Parse(Console.ReadLine());

            if (NUM < 0)
            {
                Console.WriteLine("\nNEGATIVO");
            }
            else
            {
                Console.WriteLine("\nNÃO NEGATIVO");
            }
        }
    }
}
