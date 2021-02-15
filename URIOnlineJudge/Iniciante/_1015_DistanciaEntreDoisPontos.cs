using System;
using System.Globalization;

// exercicio do urionlinejudge: 1015
namespace URIOnlineJudge.Iniciante
{
    class _1015_DistanciaEntreDoisPontos
    {
        public static void Executar()
        {
            Console.Write("Informe X1 e Y1: ");
            string[] vet1 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(vet1[0],CultureInfo.InvariantCulture);
            double y1 = double.Parse(vet1[1], CultureInfo.InvariantCulture);

            Console.Write("Informe X2 e Y2: ");
            string[] vet2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            double formula1 = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            double formula2 = Math.Sqrt(formula1);
            Console.WriteLine();
            Console.WriteLine("{0:F4}", formula2);

        }
    }
}
