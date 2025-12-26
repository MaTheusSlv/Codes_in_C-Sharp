using System;
using System.Globalization;

namespace _05_TotalAPagar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar dados da peça 1
            Console.WriteLine("Digite Código, Quantidade e Valor da peça 1 [Ex: X Y ZZ.ZZ]");
            string[] pc1 = Console.ReadLine().Split(' ');
            string cod1 = pc1[0];
            int qtd1 = int.Parse(pc1[1]);
            double valor1 = double.Parse(pc1[2], CultureInfo.InvariantCulture);

            // Solicitar dados da peça 2
            Console.WriteLine("Digite Código, Quantidade e Valor da peça 2 [Ex: X Y ZZ.ZZ]");
            string[] pc2 = Console.ReadLine().Split(' ');
            string cod2 = pc2[0];
            int qtd2 = int.Parse(pc2[1]);
            double valor2 = double.Parse(pc2[2], CultureInfo.InvariantCulture);

            // Calcular valores totais
            double vlrtot1 = qtd1 * valor1;
            double vlrtot2 = qtd2 * valor2;

            // Calcular valor total a pagar
            double total = vlrtot1 + vlrtot2;

            // Exibir resultado
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
