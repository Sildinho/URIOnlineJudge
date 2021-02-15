using System;
using System.Globalization;

// Exercícios sobre Estrutura Repetitiva FOR: 04 e uri 1116
namespace URIOnlineJudge.EstruturaRepetitiva
{
    class Secao03Exercicio04_04
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double div = (double) x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
