using System;
using System.Globalization;

// exercicio do urionlinejudge: 1008
namespace URIOnlineJudge.Iniciante
{

    class _1008_Salario
    {

        public static void Executar()
        {
            Console.Write("Informe o numero do funcionário: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Informe o numero de horas trabalhadas: ");
            int num2 = int.Parse(Console.ReadLine());
            
            Console.Write("Informe valor recebido por hora: ");
            double num3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double salario = num2 * num3;

            Console.WriteLine("\nNúmero = {0}", num1);
            Console.WriteLine();
            Console.WriteLine("salario = U$ {0}", salario);
        }
    }
}
