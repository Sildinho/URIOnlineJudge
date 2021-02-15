using System;
using System.Globalization;

// exercicio do urionlinejudge: 1014
namespace URIOnlineJudge.Iniciante
{
    class _1014_Consumo
    {
        public static void Executar()
        {
            Console.Write("Informe a distancia percorrida: ");
            int X = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Informe a distancia percorrida: ");
            float Y = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float combugasto = X / Y;

            Console.WriteLine("\n{0:F3} km/l", combugasto);
        }
    }
}

