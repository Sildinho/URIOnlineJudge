using System;
using System.Collections.Generic;
using System.Text;

// exercicio do urionlinejudge: 1011
namespace URIOnlineJudge.Iniciante
{
    class _1011_Esfera
    {
        public static void Executar()
        {
            Console.Write("Informe o raio da esfera: ");
            double raio = double.Parse(Console.ReadLine());

            double VOLUME = (4/3.0)*3.14159 * Math.Pow(raio, 3);

            Console.WriteLine("\nVOLUME = {0:F3}", VOLUME);


        }
    }
}
