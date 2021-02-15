using System;

// Exercícios sobre Estrutura Repetitiva FOR: 01 e uri 1067
namespace URIOnlineJudge.EstruturaRepetitiva
{
    class Secao03Exercicio04_01
    {
        public static void Executar()
        {
            Console.Write("Informe o número: ");
            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }
    }
}
