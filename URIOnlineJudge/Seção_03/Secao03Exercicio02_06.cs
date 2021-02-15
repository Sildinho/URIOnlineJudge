using System;
using System.Globalization;

// Exercícios sobre Estrutura Condicional (if-else): 06 e uri 1037
namespace URIOnlineJudge.EstruturaCondicional
{
    class Secao03Exercicio02_06
    {
        public static void Executar()
        {
            Console.Write("Digite um numero: ");
            double num1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (num1 < 0.00 || num1 > 100.00)
            {
                Console.WriteLine("fora do Intervalo");
            }
            else if (num1 <= 25.00)
            {
                Console.WriteLine("Intervalo(0, 25]");
            }
            else if (num1 <= 50.00)
            {
                Console.WriteLine("Intervalo(25, 50]");
            }
            else if (num1 <= 75.00)
            {
                Console.WriteLine("Intervalo(50, 75]");
            }                      
            else
            {
                Console.WriteLine("Intervalo(75, 100]");
            }
        }
    }
}
