using System;
using System.Globalization;

namespace _02_AtualizarSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cria o funcionário na memória
            Funcionario func = new Funcionario();
            
            //pede os dados do funcionário
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("\nSalário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("\nImposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //imprime os dados do funicionário
            Console.WriteLine("\nFuncionário: " + func.ToString());

            //pede a porcentagem para aumentar o salário
            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //atualiza(aumenta) o salário do funcionário
            func.AumentarSalario(porcentagem);

            //mostra os dados atualizados
            Console.WriteLine("\nDados atualizados: " + func.ToString());
        }
    }
}
