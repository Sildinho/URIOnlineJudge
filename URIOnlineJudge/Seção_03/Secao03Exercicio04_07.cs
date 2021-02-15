using System;
using System.Globalization;

// Exercícios sobre Estrutura Repetitiva FOR: 07 e uri 1143
namespace URIOnlineJudge.EstruturaRepetitiva
{
    class Secao03Exercicio04_07
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
        }
    }
}
