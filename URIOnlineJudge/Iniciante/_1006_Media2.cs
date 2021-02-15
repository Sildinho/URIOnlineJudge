using System;
using System.Collections.Generic;
using System.Text;

// exercicio do urionlinejudge: 1006
namespace URIOnlineJudge.Iniciante
{
    class _1006_Media2
    {
        public static void Executar()
        {
            Console.Write("nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());

            double MEDIA = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5))/10;

            Console.WriteLine("\nMEDIA = {0:F1}",MEDIA);
        }
    }
}
