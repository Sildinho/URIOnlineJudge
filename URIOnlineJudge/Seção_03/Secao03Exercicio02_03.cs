using System;
using System.Globalization;

// Exercícios sobre Estrutura Condicional (if-else): 03 e uri 1044
namespace URIOnlineJudge.EstruturaCondicional
{
    class Secao03Exercicio02_03
    {
        public static void Executar()
        {
            Console.Write("Informe A e B: ");
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0], CultureInfo.InvariantCulture);
            int B = int.Parse(vet[1], CultureInfo.InvariantCulture);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("\nSão multiplos");
            }
            else
            {
                Console.WriteLine("\nNão são multiplos");
            }

        }
    }
}
