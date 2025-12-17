using System;
using System.Globalization;

namespace _05_ValorAPagar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Código do produto e a Quantidade [Ex= CC QQ]:");
            string[] str = Console.ReadLine().Split(' ');

            int cod = int.Parse(str[0]);
            int qtd = int.Parse(str[1]);

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

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
