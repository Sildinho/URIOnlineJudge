using System;
using System.Globalization;

// exercicio do urionlinejudge: 0000
namespace URIOnlineJudge.Iniciante
{

    class _1012_Area
    {

        public static void Executar()
        {
            string[] vet = Console.ReadLine().Split(' ');
                        
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double TRIANGULO = (A * C) / 2;
            double CIRCULO = 3.14159 * (C * C);
            double TRAPEZIO = ((A + B) * C) / 2;
            double QUADRADO = Math.Pow(B, 2);
            double RETANGULO = A * B;

            Console.WriteLine("TRIANGULO: {0:F3}", TRIANGULO);
            Console.WriteLine("CIRCULO: {0:F3}", CIRCULO);
            Console.WriteLine("TRAPEZIO: {0:F3}", TRAPEZIO);
            Console.WriteLine("QUADRADO: {0:F3}", QUADRADO);
            Console.WriteLine("RETANGULO: {0:F3}", RETANGULO);
        }
    }
}
