using System;
using System.Globalization;

// exercicio do urionlinejudge: 1009
namespace URIOnlineJudge.Iniciante
{
    class _1009_SalarioComBonus
    {
        public static void Executar()
        {
            Console.Write("Informe o nome do vendedor: ");
            string nome = Console.ReadLine();
            Console.Write("Informe o salario: ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Informe o valor com vendas: ");
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double comissao = (vendas /100.00) * 15;

            //Console.WriteLine(comissao);

            Console.WriteLine("\nTOTAL = R$ {0:F2} ", salario + comissao);
        }
    }
}
