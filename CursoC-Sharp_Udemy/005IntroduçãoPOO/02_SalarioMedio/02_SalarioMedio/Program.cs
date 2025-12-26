using System;
using System.Globalization;

namespace _02_SalarioMedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cria os funcionários na memória
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            //pede os dados do funcionario 1
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            //pede os dados do funcionario 2
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //calcula o salário médio
            double sal_med = (f1.salario + f2.salario) / 2;

            //informa o salário médio
            Console.WriteLine("");
            Console.WriteLine("Salário Médio = " + sal_med.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
