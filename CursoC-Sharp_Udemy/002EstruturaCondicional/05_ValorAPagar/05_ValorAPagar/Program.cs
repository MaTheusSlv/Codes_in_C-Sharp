using System;
using System.Globalization;

namespace _05_ValorAPagar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pedindo o cod e qtd do produto
            Console.WriteLine("Digite o Código do produto e a Quantidade [Ex= CC QQ]:");
            string[] str = Console.ReadLine().Split(' ');

            int cod = int.Parse(str[0]);
            int qtd = int.Parse(str[1]);

            //calculando o valor a pagar de acordo com o código do produto (tabelado)
            double total;

            if (cod == 1)
            {
                total = qtd * 4.0;
            }
            else if (cod == 2)
            {
                total = qtd * 4.5;
            }
            else if (cod == 3)
            {
                total = qtd * 5.0;
            }
            else if (cod == 4)
            {
                total = qtd * 2.0;
            }
            else
            {
                total = qtd * 1.5;
            }

            //mostrando o valor a pagar
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
