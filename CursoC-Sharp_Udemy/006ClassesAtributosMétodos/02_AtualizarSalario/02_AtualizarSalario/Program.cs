using System;
using System.Globalization;

namespace _02_AtualizarSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("\nSalário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\nImposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nFuncionário: " + func.ToString());

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            func.AumentarSalario(porcentagem);

            Console.WriteLine("\nDados atualizados: " + func.ToString());
        }
    }
}
