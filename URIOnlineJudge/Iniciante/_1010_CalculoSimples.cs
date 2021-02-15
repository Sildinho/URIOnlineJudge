using System;
using System.Globalization;

// exercicio do urionlinejudge: 1010
namespace URIOnlineJudge.Iniciante
{

    class _1010_CalculoSimples
    {

        public static void Executar()
        {            
            string[] vet1 = Console.ReadLine().Split(' ');

            int cod1 = int.Parse(vet1[0]);
            int qtdade1 = int.Parse(vet1[1]);
            double vlunpc1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');

            int cod2 = int.Parse(vet2[0]);
            int qtdade2 = int.Parse(vet2[1]);
            double vlunpc2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double vlpago = (vlunpc1 * qtdade1) + (vlunpc2 * qtdade2);

            Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", vlpago);
        }
    }
}
