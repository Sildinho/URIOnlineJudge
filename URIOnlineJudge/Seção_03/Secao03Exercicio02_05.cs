using System;
using System.Globalization;

// Exercícios sobre Estrutura Condicional (if-else): 05 E URI 1038
namespace URIOnlineJudge.EstruturaCondicional
{
    class Secao03Exercicio02_05
    {
        public static void Executar()
        {
            string[] vet = Console.ReadLine().Split(' ');
            int cod = int.Parse(vet[0]);
            int qtdade = int.Parse(vet[1]);

            double total;
            if (cod == 1)
            {
                total = qtdade * 4.00;
            }
            else if(cod == 2)
            {
                total = qtdade * 4.50;
            }
            else if(cod == 3)
            {
                total = qtdade * 5.00;
            }
            else if(cod == 4)
            {
                total = qtdade * 2.00;
            }
            else
            {
                total = qtdade * 1.50;
            }

            Console.WriteLine("\nTOTAL: R$ {0:F2}", total);
        }
    }
}
