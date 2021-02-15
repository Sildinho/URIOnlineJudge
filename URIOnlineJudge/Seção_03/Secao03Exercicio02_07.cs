using System;
using System.Globalization;

// Exercícios sobre Estrutura Condicional (if-else): 07 e uri 1041
namespace URIOnlineJudge.EstruturaCondicional
{
    class Secao03Exercicio02_07
    {
        public static void Executar()
        {
            Console.Write("Digite os valor para X e Y: ");
            string[] vet = Console.ReadLine().Split(' ');

            double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if ( x == 0 && y == 0)
            {
                Console.WriteLine("\nOrigiem");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("\nQ 1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("\nQ 2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("\nQ 3");
            }
            else 
            {
                Console.WriteLine("\nQ 4");
            }
        }
    }
}
