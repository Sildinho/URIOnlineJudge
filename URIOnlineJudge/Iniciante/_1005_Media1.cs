using System;
using System.Globalization;

// exercicio do urionlinejudge: 1005
namespace URIOnlineJudge.Iniciante
{
    class _1005_Media1
    {
        public static void Executar()
        {
            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            double media = ((nota1 * 3.5)+(nota2 * 7.5))/11;

            Console.WriteLine(nota1 * 3.5);
            Console.WriteLine(nota2 * 7.5);

            Console.WriteLine("\nMEDIA = {0:F5}", media);


        }
    }
}
