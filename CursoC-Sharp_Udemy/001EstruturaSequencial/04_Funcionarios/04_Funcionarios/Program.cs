using System;
using System.Globalization;

namespace _04_Funcionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solicitando as informações do funcionário
            Console.WriteLine("Digite o número do funcionário:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas:");
            int hrs = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quanto ganha por hora:");
            double porhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //calculando o salário
            double recebe = hrs * porhora;
            
            //mostrando o resultado
            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = U$ " + recebe.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
