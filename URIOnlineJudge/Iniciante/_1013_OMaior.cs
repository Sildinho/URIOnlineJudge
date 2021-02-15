using System;
using System.Collections.Generic;
using System.Text;

// exercicio do urionlinejudge: 1013
namespace URIOnlineJudge.Iniciante
{
    class _1013_OMaior
    {
        public static void Executar()
        {
            Console.Write("Informe o primeiro numero: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo numero: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Informe o terceiro numero: ");
            int C = int.Parse(Console.ReadLine());

            int MaiorAB = (A + B + (A - B)) / 2;

            if (B < MaiorAB)
            {
                Console.WriteLine();
                Console.WriteLine(A + " eh o maior");
            }
            else if (C < MaiorAB)
            {
                Console.WriteLine();
                Console.WriteLine(B + " eh o maior");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(C + " eh o maior");
            }
        }
    }
}
