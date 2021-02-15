using System;
using System.Globalization;

// Exercícios sobre Estrutura Repetitiva FOR: 05 e uri 1153
namespace URIOnlineJudge.EstruturaRepetitiva
{
    class Secao03Exercicio04_05
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());

            int fat = 1;

            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        }
    }
}
