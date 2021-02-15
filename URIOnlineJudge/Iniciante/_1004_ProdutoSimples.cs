using System;
using System.Globalization;

// exercicio do urionlinejudge: 1004
namespace URIOnlineJudge.Iniciante
{

    class _1004_ProdutoSimples
    {

        public static void Executar()
        {

            Console.Write("Digite um numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int PROD = num1 * num2;

            Console.WriteLine("\nPROD = {0}",PROD);
        }
    }
}