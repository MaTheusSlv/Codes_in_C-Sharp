using System;
using System.Globalization;

namespace _08_ImpostoLisarb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salário do Colaborador:");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            //Verifica o imposto a ser aplicado
            if (salario <= 2000.00)
            {
                imposto = 0.00;
            }
            else if (salario <= 3000.00)
            {
                imposto = (salario - 2000.00) * 0.08;
            }
            else if (salario <= 4500.00)
            {
                imposto = (salario - 3000.00) * 0.18 + 1000.00 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
            }

            //Mostra o valor a pagar
            if (imposto == 0.00)
            {
                Console.WriteLine("Insento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
