using System;
// exercicio do urionlinejudge: 1003
namespace URIOnlineJudge.Iniciante
{

    class _1003_SomaSimples
    {

        public static void Executar()
        {
            Console.Write("Digite um numero: ");
            int nun1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite outro numero: ");
            int nun2 = int.Parse(Console.ReadLine());

            int soma = nun1 + nun2;

            Console.Write("\nSoma = {0}", soma);
            Console.WriteLine();
        }
    }
}
