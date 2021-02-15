using System;
using System.Globalization;

// exercicio do urionlinejudge: 1007
namespace URIOnlineJudge.Iniciante
{

    class _1007_Diferença
    {

        public static void Executar()
        {
            Console.Write("Informe o primeiro valor: ");
            int a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o primeiro valor: ");
            int b = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o primeiro valor: ");
            int c = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o primeiro valor: ");
            int d = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int difereca = a * b - c * d;
            Console.WriteLine();
            Console.WriteLine("DIFERENÇA = {0}", difereca);


        }
    }
}
