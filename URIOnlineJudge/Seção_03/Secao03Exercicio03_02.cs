using System;
using System.Globalization;

// Exercícios sobre Estrutura Repetitiva WHILE: 02 e uri 1115
namespace URIOnlineJudge.EstruturaRepetitiva
{
    class Secao03Exercicio03_02
    {
        public static void Executar()
        {
            Console.Write("Informe as coordenadas: ");
            string[] vet = Console.ReadLine().Split(' ');

            double X = double.Parse(vet[0]);
            double Y = double.Parse(vet[1]);

            while ( X != 0 && Y != 0)
            {
                if ( X > 0 && Y > 0)
                {
                    Console.WriteLine("\nPrimeiro");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("\nSegundo");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("\nTerceiro");
                }
                else
                {
                    Console.WriteLine("\nQuarto");
                }

                vet = Console.ReadLine().Split(' ');
                X = double.Parse(vet[0]);
                Y = double.Parse(vet[1]);

            }
        }
    }
}
