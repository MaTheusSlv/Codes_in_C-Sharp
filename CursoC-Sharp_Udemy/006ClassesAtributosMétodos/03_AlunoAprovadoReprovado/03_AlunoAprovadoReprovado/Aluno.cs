using System;

namespace _03_AlunoAprovadoReprovado
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        //calcula a nota final
        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        //verifica se o aluno está aprovando
        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //verifica se está aprovado, se não, mostra o quanto falta à partir da nota final
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.00;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}
