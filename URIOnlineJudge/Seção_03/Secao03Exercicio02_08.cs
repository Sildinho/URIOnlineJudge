using System;
using System.Globalization;

// Exercícios sobre Estrutura Condicional (if-else): 08 e uri 1051
namespace URIOnlineJudge.EstruturaCondicional
{
    class Secao03Exercicio02_08
    {
        public static void Executar()
        {
            Console.Write("Digite os valor valor do salario: ");

            double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double IR;
            if (sal <= 2000.00)
            {
                IR = 0.00;
            }
            else if (sal <= 3000.00)
            {
                IR = (sal - 2000.00) * 0.08;
            }
            else if (sal <= 4500.00)
            {
                IR = (sal - 3000.00) * 0.18 + 1000.00 * 0.08;
            }
            else
            {
                IR = (sal - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
            }
            if (IR == 0.00)
            {
                Console.WriteLine("\nIsento.");
            }
            else
            {
                Console.WriteLine("\nR $ " + IR.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
