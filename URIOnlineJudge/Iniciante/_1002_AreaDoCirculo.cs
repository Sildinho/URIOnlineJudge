using System;
using System.Globalization;

// exercicio do urionlinejudge: 1002
namespace URIOnlineJudge.Iniciante
{
    class _1002_AreaDoCirculo
    {
        public static void Executar()
        {
            Console.Write("Informe do valor do raio: ");
            double area = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double A = 3.14159 * Math.Pow(area, 2);

            Console.WriteLine("A = {0}", A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
