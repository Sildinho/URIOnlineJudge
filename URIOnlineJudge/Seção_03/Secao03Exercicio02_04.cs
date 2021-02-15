using System;
using System.Globalization;

// Exercícios sobre Estrutura Condicional (if-else): 04 e uri 1046
namespace URIOnlineJudge.EstruturaCondicional
{
    class Secao03Exercicio02_04
    {
        public static void Executar()
        {
            Console.Write("Informe a hora inical e a hora final do jogo: ");
            string[] vet = Console.ReadLine().Split(' ');

            int HI = int.Parse(vet[0], CultureInfo.InvariantCulture);
            int HF = int.Parse(vet[1], CultureInfo.InvariantCulture);

            int duracao;

            if (HI < HF)
            {
                duracao = HF - HI;
            }
            else
            {
                duracao = 24 - HI + HF;
            }
            Console.WriteLine("\nO JOGO DUROU {0} HORA(S) ", duracao);
        }
    }
}