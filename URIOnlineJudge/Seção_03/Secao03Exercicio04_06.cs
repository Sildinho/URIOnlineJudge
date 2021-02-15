using System;
using System.Globalization;

// Exercícios sobre Estrutura Repetitiva FOR: 06 e uri 1157
namespace URIOnlineJudge.EstruturaRepetitiva
{
    class Secao03Exercicio04_06
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
