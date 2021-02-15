using System;
using System.Globalization;

// Exercícios sobre Estrutura Repetitiva WHILE: 03 e uri 1134
namespace URIOnlineJudge.EstruturaRepetitiva
{
    class Secao03Exercicio03_03
    {
        public static void Executar()
        {
            Console.Write("Digite o código do produto: ");

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3)
                {
                    diesel = diesel + 1;
                }
                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}