using System;
using System.Globalization;

namespace _03_AlunoAprovadoReprovado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cria o aluno na memória
            Aluno aluno = new Aluno();

            //pede as infos do aluno
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite as três notas do aluno: \n");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //mostra a nota final
            Console.Write("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture) + "\n");

            //verifica se está aprovado e quanto falta se não estiver
            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
