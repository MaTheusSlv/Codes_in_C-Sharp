using System;
using System.Globalization;

namespace _02_AtualizarSalario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        //calcula o salário liquido
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        //faz o aumento do salário com base na porcentagem
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * (porcentagem / 100));
        }

        //sobrescrevendo o método ToString pra mostrar da nossa forma
        public override string ToString()
        {
            return Nome + ", R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
