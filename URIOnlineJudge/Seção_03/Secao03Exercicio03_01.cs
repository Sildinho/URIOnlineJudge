using System;
using System.Globalization;

// Exercícios sobre Estrutura Repetitiva WHILE: 01 e uri 1114
namespace URIOnlineJudge.EstruturaRepetitiva
{
    class Secao03Exercicio03_01
    {
        public static void Executar()
        {
            Console.Write("Informe a senha: ");
            int X = int.Parse(Console.ReadLine());

            while ( X != 2002)
            {
                Console.Write("\nSenha incorreta.");
                Console.WriteLine();
                Console.Write("\nInforme a senha: ");

                X = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("\nAcesso permitido.");
        }
    }
}
